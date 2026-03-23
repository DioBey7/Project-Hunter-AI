using UnityEngine;

public class CheckHearing : BTNode
{
    private Transform _transform;
    private Transform _target;
    private GridManager _grid;
    private float _baseHearingRange;
    private float _memoryBuffer = 3f;
    private float _timeSinceLastDetection = 999f;

    public CheckHearing(Transform transform, Transform target, GridManager grid, float baseHearingRange)
    {
        _transform = transform;
        _target = target;
        _grid = grid;
        _baseHearingRange = baseHearingRange;
    }

    public override NodeState Evaluate()
    {
        Node targetNode = _grid.NodeFromWorldPoint(_target.position);
        float currentHearingRange = _baseHearingRange * targetNode.terrainCost;

        if (Vector3.Distance(_transform.position, _target.position) <= currentHearingRange)
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

