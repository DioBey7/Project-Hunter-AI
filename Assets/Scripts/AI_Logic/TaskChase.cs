using UnityEngine;
using System.Collections.Generic;

public class TaskChase : BTNode
{
    private Transform _transform;
    private Transform _target;
    private float _speed = 5f;
    private Pathfinding _pathfinding;
    private List<Vector3> _currentPath;
    private int _targetIndex;
    private LineRenderer _lineRenderer;

    public TaskChase(Transform transform, Transform target, Pathfinding pathfinding, LineRenderer lineRenderer)
    {
        _transform = transform;
        _target = target;
        _pathfinding = pathfinding;
        _lineRenderer = lineRenderer;
    }

    public override NodeState Evaluate()
    {
        _currentPath = _pathfinding.FindPath(_transform.position, _target.position);
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