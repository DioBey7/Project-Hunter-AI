using UnityEngine;

public class CheckHearing : BTNode
{
    private Transform _transform;
    private Transform _target;
    private GridManager _grid;
    private float _baseHearingRange;

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
            state = NodeState.Success;
            return state;
        }

        state = NodeState.Failure;
        return state;
    }
}
