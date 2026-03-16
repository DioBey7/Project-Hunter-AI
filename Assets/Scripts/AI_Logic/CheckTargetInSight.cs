using UnityEngine;

public class CheckTargetInSight : BTNode
{
    private Transform _transform;
    private Transform _target;
    private float _fovRange;

    public CheckTargetInSight(Transform transform, Transform target, float fovRange)
    {
        _transform = transform;
        _target = target;
        _fovRange = fovRange;
    }

    public override NodeState Evaluate()
    {
        if (Vector3.Distance(_transform.position, _target.position) <= _fovRange)
        {
            state = NodeState.Success;
            return state;
        }

        state = NodeState.Failure;
        return state;
    }
}