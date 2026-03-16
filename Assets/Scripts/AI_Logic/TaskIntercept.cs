using UnityEngine;
using System.Collections.Generic;

public class TaskIntercept : BTNode
{
    private Transform _transform;
    private Transform _target;
    private TargetTracker _targetTracker;
    private float _speed;
    private Pathfinding _pathfinding;
    private List<Vector3> _currentPath;
    private int _targetIndex;
    private LineRenderer _lineRenderer;
    private GridManager _grid;

    public TaskIntercept(Transform transform, Transform target, TargetTracker targetTracker, float speed, Pathfinding pathfinding, LineRenderer lineRenderer, GridManager grid)
    {
        _transform = transform;
        _target = target;
        _targetTracker = targetTracker;
        _speed = speed;
        _pathfinding = pathfinding;
        _lineRenderer = lineRenderer;
        _grid = grid;
    }

    public override NodeState Evaluate()
    {
        float distance = Vector3.Distance(_transform.position, _target.position);
        float timeToIntercept = distance / _speed;
        
        Vector3 predictedPosition = _target.position + (_targetTracker.Velocity * timeToIntercept);
        Node predictedNode = _grid.NodeFromWorldPoint(predictedPosition);
        predictedPosition = predictedNode.worldPosition;

        _currentPath = _pathfinding.FindPath(_transform.position, predictedPosition);
        _targetIndex = 0;

        if (_currentPath != null && _currentPath.Count > 0)
        {
            if (_lineRenderer != null)
            {
                _lineRenderer.positionCount = _currentPath.Count;
                _lineRenderer.SetPositions(_currentPath.ToArray());
            }

            Vector3 currentWaypoint = _currentPath[_targetIndex];
            if (Vector3.Distance(_transform.position, currentWaypoint) < 0.1f)
            {
                _targetIndex++;
                if (_targetIndex >= _currentPath.Count)
                {
                    state = NodeState.Success;
                    if (_lineRenderer != null) _lineRenderer.positionCount = 0;
                    return state;
                }
                currentWaypoint = _currentPath[_targetIndex];
            }

            _transform.position = Vector3.MoveTowards(_transform.position, currentWaypoint, _speed * Time.deltaTime);
            _transform.LookAt(currentWaypoint);
        }
        else
        {
            if (_lineRenderer != null) _lineRenderer.positionCount = 0;
        }

        state = NodeState.Running;
        return state;
    }
}
