using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(AudioSource))]
public class HunterAI : BTree
{
    public Transform target;
    public TargetTracker targetTracker;
    public Transform[] waypoints;
    public HunterProfile profile;
    public LayerMask obstacleMask;

    private Pathfinding _pathfinding;
    private GridManager _grid;
    private float _currentHearingRange;
    private LineRenderer _lineRenderer;
    private AudioSource _audioSource;
    private bool _isChasing = false;
    private bool _isSimulationActive = true;
    private float _suspicionTimer = 0f;

    protected override void Start()
    {
        _pathfinding = FindFirstObjectByType<Pathfinding>();
        _grid = FindFirstObjectByType<GridManager>();
        _lineRenderer = GetComponent<LineRenderer>();
        _audioSource = GetComponent<AudioSource>();

        _lineRenderer.startWidth = 0.1f;
        _lineRenderer.endWidth = 0.1f;
        _lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        _lineRenderer.startColor = Color.red;
        _lineRenderer.endColor = Color.black;

        _audioSource.loop = true;
        _audioSource.spatialBlend = 1f;
        _audioSource.volume = 0.8f;

        base.Start();

        if (profile != null && profile.patrolSound != null)
        {
            PlaySound(profile.patrolSound);
        }
    }

    protected override BTNode SetupTree()
    {
        BTNode root = new Selector(new List<BTNode>
        {
            new TaskCatch(transform, target, profile.catchRadius, _audioSource, profile.catchSound),
            
            new Sequence(new List<BTNode>
            {
                new CheckTargetInSight(transform, target, profile.fovRadius, profile.fovAngle, obstacleMask),
                new TaskIntercept(transform, target, targetTracker, profile.baseSpeed, _pathfinding, _lineRenderer, _grid)
            }),
            
            new Sequence(new List<BTNode>
            {
                new CheckHearing(transform, target, _grid, profile.baseHearingRange),
                new TaskIntercept(transform, target, targetTracker, profile.baseSpeed, _pathfinding, _lineRenderer, _grid)
            }),
            
            new TaskPatrol(transform, waypoints, _pathfinding, _lineRenderer)
        });

        return root;
    }

    protected override void Update()
    {
        if (!_isSimulationActive) return;
        
        if (Time.timeScale == 0f)
        {
            _isSimulationActive = false;
            _audioSource.Stop();
            return;
        }

        base.Update();

        if (_grid != null && target != null && profile != null)
        {
            Node targetNode = _grid.NodeFromWorldPoint(target.position);
            _currentHearingRange = profile.baseHearingRange * targetNode.terrainCost;

            Vector3 dirToTarget = target.position - transform.position;
            bool canSee = dirToTarget.magnitude <= profile.fovRadius && Vector3.Angle(transform.forward, dirToTarget) < profile.fovAngle / 2f && !Physics.Raycast(transform.position, dirToTarget.normalized, dirToTarget.magnitude, obstacleMask);
            bool canHear = dirToTarget.magnitude <= _currentHearingRange;

            if (canSee || canHear)
            {
                _suspicionTimer = 3f;
            }
            else if (_suspicionTimer > 0f)
            {
                _suspicionTimer -= Time.deltaTime;
            }

            bool shouldChase = (canSee || canHear || _suspicionTimer > 0f);

            if (shouldChase && !_isChasing)
            {
                _isChasing = true;
                PlaySound(profile.chaseSound);
            }
            else if (!shouldChase && _isChasing)
            {
                _isChasing = false;
                PlaySound(profile.patrolSound);
            }

            if (_isChasing)
            {
                float distanceRatio = Mathf.Clamp01(dirToTarget.magnitude / profile.fovRadius);
                _audioSource.pitch = Mathf.Lerp(profile.maxAudioPitch, profile.minAudioPitch, distanceRatio);
            }
            else
            {
                _audioSource.pitch = profile.minAudioPitch;
            }
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && _audioSource != null)
        {
            _audioSource.clip = clip;
            _audioSource.Play();
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if (profile == null) return;

        Handles.color = new Color(1f, 0.8f, 0f, 0.15f);
        Vector3 forward = transform.forward;
        Vector3 startPoint = Quaternion.Euler(0, -profile.fovAngle / 2f, 0) * forward;
        Handles.DrawSolidArc(transform.position, Vector3.up, startPoint, profile.fovAngle, profile.fovRadius);

        Handles.color = new Color(1f, 0.8f, 0f, 0.8f);
        Vector3 rightFov = Quaternion.Euler(0, profile.fovAngle / 2f, 0) * transform.forward * profile.fovRadius;
        Vector3 leftFov = Quaternion.Euler(0, -profile.fovAngle / 2f, 0) * transform.forward * profile.fovRadius;
        Handles.DrawLine(transform.position, transform.position + rightFov);
        Handles.DrawLine(transform.position, transform.position + leftFov);

        float hearingRadius = Application.isPlaying ? _currentHearingRange : profile.baseHearingRange;
        Handles.color = new Color(0.6f, 0f, 0f, 0.1f);
        Handles.DrawSolidDisc(transform.position, Vector3.up, hearingRadius);
        Handles.color = new Color(0.8f, 0f, 0f, 0.5f);
        Handles.DrawWireDisc(transform.position, Vector3.up, hearingRadius);

        if (Application.isPlaying && target != null && targetTracker != null && _isChasing && _isSimulationActive)
        {
            float dist = Vector3.Distance(transform.position, target.position);
            float time = dist / profile.baseSpeed;
            Vector3 predictedPos = target.position + (targetTracker.Velocity * time);

            Handles.color = Color.cyan;
            Handles.DrawDottedLine(target.position, predictedPos, 4f);
            
            Handles.color = new Color(0f, 1f, 1f, 0.3f);
            Handles.DrawSolidDisc(predictedPos, Vector3.up, 0.5f);
        }

        Handles.color = new Color(1f, 0f, 0f, 0.2f);
        Handles.DrawSolidDisc(transform.position, Vector3.up, profile.catchRadius);

        GUIStyle hudStyle = new GUIStyle();
        hudStyle.normal.textColor = Color.white;
        hudStyle.fontSize = 13;
        hudStyle.fontStyle = FontStyle.Bold;
        hudStyle.alignment = TextAnchor.MiddleCenter;

        string stateText = "💤 IDLE";
        if (Application.isPlaying)
        {
            if (!_isSimulationActive) stateText = "💀 TERMINATED";
            else stateText = _isChasing ? "🔴 HUNTING" : "⚪ PATROLLING";
        }

        Vector3 textPos = transform.position + Vector3.up * 2.5f;
        Handles.Label(textPos, $"[ AI CORE ]\nState: {stateText}", hudStyle);
    }
#endif
}