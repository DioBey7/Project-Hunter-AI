using UnityEngine;

public class TaskCatch : BTNode
{
    private Transform _transform;
    private Transform _target;
    private float _catchRadius;
    private AudioSource _audioSource;
    private AudioClip _catchSound;

    public TaskCatch(Transform transform, Transform target, float catchRadius, AudioSource audioSource, AudioClip catchSound)
    {
        _transform = transform;
        _target = target;
        _catchRadius = catchRadius;
        _audioSource = audioSource;
        _catchSound = catchSound;
    }

    public override NodeState Evaluate()
    {
        if (Vector3.Distance(_transform.position, _target.position) <= _catchRadius)
        {
            if (_catchSound != null && _audioSource != null)
            {
                _audioSource.PlayOneShot(_catchSound);
            }
            
            Debug.LogWarning("[ FATAL ] TARGET ACQUIRED. SIMULATION TERMINATED.");
            Time.timeScale = 0f;
            state = NodeState.Success;
            return state;
        }

        state = NodeState.Failure;
        return state;
    }
}
