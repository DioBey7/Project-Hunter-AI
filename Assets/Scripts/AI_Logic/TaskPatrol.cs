using UnityEngine;
using System.Collections.Generic;

public class TaskPatrol : BTNode
{
    private Transform _transform;
    private Transform[] _waypoints;
    private int _currentWaypointIndex = 0;
    private float _speed = 2f;
    private Pathfinding _pathfinding;
    private List<Vector3> _currentPath;
    private int _pathIndex;
    private LineRenderer _lineRenderer;

    public TaskPatrol(Transform transform, Transform[] waypoints, Pathfinding pathfinding, LineRenderer lineRenderer)
    {
        _transform = transform;
        _waypoints = waypoints;
        _pathfinding = pathfinding;
        _lineRenderer = lineRenderer;
    }

    public override NodeState Evaluate()
    {
        Transform wp = _waypoints[_currentWaypointIndex];
        
        if (Vector3.Distance(_transform.position, wp.position) < 0.1f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
            _currentPath = null;
            if (_lineRenderer != null) _lineRenderer.positionCount = 0;
        }
        else
        {
            if (_currentPath == null || _currentPath.Count == 0)
            {
                _currentPath = _pathfinding.FindPath(_transform.position, wp.position);
                _pathIndex = 0;
            }

            if (_currentPath != null && _currentPath.Count > 0)
            {
                if (_lineRenderer != null)
                {
                    _lineRenderer.positionCount = _currentPath.Count - _pathIndex;
                    for (int i = _pathIndex; i < _currentPath.Count; i++)
                    {
                        _lineRenderer.SetPosition(i - _pathIndex, _currentPath[i]);
                    }
                }

                if (_pathIndex < _currentPath.Count)
                {
                    Vector3 currentPathNode = _currentPath[_pathIndex];
                    if (Vector3.Distance(_transform.position, currentPathNode) < 0.1f)
                    {
                        _pathIndex++;
                        if (_pathIndex < _currentPath.Count)
                        {
                            currentPathNode = _currentPath[_pathIndex];
                        }
                    }

                    if (_pathIndex < _currentPath.Count)
                    {
                        _transform.position = Vector3.MoveTowards(_transform.position, currentPathNode, _speed * Time.deltaTime);
                        _transform.LookAt(currentPathNode);
                    }
                }
            }
        }

        state = NodeState.Running;
        return state;
    }
}
