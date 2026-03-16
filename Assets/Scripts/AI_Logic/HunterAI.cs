using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(AudioSource))]
public class HunterAI : BTree
{
    public Transform target;
    public TargetTracker targetTracker;
    public Transform[] waypoints;
    public float fovRange = 6f;
    public float baseHearingRange = 3f;
    public float hunterSpeed = 5f;

    public AudioClip patrolSound;
    public AudioClip chaseSound;

    private Pathfinding _pathfinding;
    private GridManager _grid;
    private float _currentHearingRange;
    private LineRenderer _lineRenderer;
    private AudioSource _audioSource;

    private bool _isChasing = false;

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
        
        PlaySound(patrolSound);
    }

    protected override BTNode SetupTree()
    {
        BTNode root = new Selector(new List<BTNode>
        {
            new Sequence(new List<BTNode>
            {
                new CheckTargetInSight(transform, target, fovRange),
                new TaskIntercept(transform, target, targetTracker, hunterSpeed, _pathfinding, _lineRenderer, _grid)
            }),
            new Sequence(new List<BTNode>
            {
                new CheckHearing(transform, target, _grid, baseHearingRange),
                new TaskIntercept(transform, target, targetTracker, hunterSpeed, _pathfinding, _lineRenderer, _grid)
            }),
            new TaskPatrol(transform, waypoints, _pathfinding, _lineRenderer)
        });

        return root;
    }

    protected override void Update()
    {
        base.Update();
        
        if (_grid != null && target != null)
        {
            Node targetNode = _grid.NodeFromWorldPoint(target.position);
            _currentHearingRange = baseHearingRange * targetNode.terrainCost;

            bool canSee = Vector3.Distance(transform.position, target.position) <= fovRange;
            bool canHear = Vector3.Distance(transform.position, target.position) <= _currentHearingRange;

            bool shouldChase = canSee || canHear;

            if (shouldChase && !_isChasing)
            {
                _isChasing = true;
                PlaySound(chaseSound);
            }
            else if (!shouldChase && _isChasing)
            {
                _isChasing = false;
                PlaySound(patrolSound);
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

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, fovRange);

        if (Application.isPlaying && _grid != null && target != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, _currentHearingRange);
            
            if (targetTracker != null)
            {
                float dist = Vector3.Distance(transform.position, target.position);
                float time = dist / hunterSpeed;
                Vector3 pred = target.position + (targetTracker.Velocity * time);
                Gizmos.color = Color.blue;
                Gizmos.DrawWireSphere(pred, 0.4f);
                Gizmos.DrawLine(target.position, pred);
            }
        }
        else
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, baseHearingRange);
        }
    }
}