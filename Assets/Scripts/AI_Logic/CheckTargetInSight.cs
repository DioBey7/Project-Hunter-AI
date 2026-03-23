using UnityEngine;

public class CheckTargetInSight : BTNode
{
    private Transform _transform;
    private Transform _target;
    private float _fovRadius;
    private float _fovAngle;
    private LayerMask _obstacleMask;
    private float _memoryBuffer = 3f;
    private float _timeSinceLastDetection = 999f;

    public CheckTargetInSight(Transform transform, Transform target, float fovRadius, float fovAngle, LayerMask obstacleMask)
    {
        _transform = transform;
        _target = target;
        _fovRadius = fovRadius;
        _fovAngle = fovAngle;
        _obstacleMask = obstacleMask;
    }

    public override NodeState Evaluate()
    {
        Vector3 directionToTarget = _target.position - _transform.position;
        bool canSee = false;

        if (directionToTarget.magnitude <= _fovRadius)
        {
            if (Vector3.Angle(_transform.forward, directionToTarget) < _fovAngle / 2f)
            {
                if (!Physics.Raycast(_transform.position, directionToTarget.normalized, directionToTarget.magnitude, _obstacleMask))
                {
                    canSee = true;
                }
            }
        }

        if (canSee)
        {
            _timeSinceLastDetection = 0f;
            state = NodeState.Success;
            return state;
        }

        _timeSinceLastDetection += Time.deltaTime;
        
        if (_timeSinceLastDetection < _memoryBuffer)
        {
            state = NodeState.Success;
            return state;
        }

        state = NodeState.Failure;
        return state;
    }
}