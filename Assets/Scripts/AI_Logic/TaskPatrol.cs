using UnityEngine;
using System.Collections.Generic;

public class TaskPatrol : BTNode
{
    private Transform _transform;
    private Transform[] _waypoints;
    private Pathfinding _pathfinding;
    private LineRenderer _lineRenderer;
    private int _currentWaypointIndex = 0;
    private float _speed = 2f;
    private List<Vector3> _currentPath;
    private int _pathIndex;
    private float _pathUpdateTimer = 0f;

    public TaskPatrol(Transform transform, Transform[] waypoints, Pathfinding pathfinding, LineRenderer lineRenderer)
    {
        _transform = transform;
        _waypoints = waypoints;
        _pathfinding = pathfinding;
        _lineRenderer = lineRenderer;
    }

    public override NodeState Evaluate()
    {
        if (_waypoints == null || _waypoints.Length == 0) return NodeState.Failure;

        Transform wp = _waypoints[_currentWaypointIndex];
        _pathUpdateTimer -= Time.deltaTime;

        if (_pathUpdateTimer <= 0f || _currentPath == null)
        {
            _currentPath = _pathfinding.FindPath(_transform.position, wp.position);
            _pathIndex = 0;
            _pathUpdateTimer = 0.5f;
        }

        if (_currentPath != null && _pathIndex < _currentPath.Count)
        {
            Vector3 currentWaypoint = _currentPath[_pathIndex];
            _transform.position = Vector3.MoveTowards(_transform.position, currentWaypoint, _speed * Time.deltaTime);

            Vector3 direction = currentWaypoint - _transform.position;
            if (direction.magnitude > 0.1f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                _transform.rotation = Quaternion.Slerp(_transform.rotation, targetRotation, 5f * Time.deltaTime);
            }

            if (Vector3.Distance(_transform.position, currentWaypoint) < 0.6f)
            {
                _pathIndex++;
            }

            if (_lineRenderer != null)
            {
                int remainingNodes = _currentPath.Count - _pathIndex;
                if (remainingNodes > 0)
                {
                    _lineRenderer.positionCount = remainingNodes;
                    for (int i = 0; i < remainingNodes; i++)
                    {
                        _lineRenderer.SetPosition(i, _currentPath[i + _pathIndex]);
                    }
                }
                else
                {
                    _lineRenderer.positionCount = 0;
                }
            }
        }

        if (Vector3.Distance(_transform.position, wp.position) < 1.5f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
            _currentPath = null;
        }

        state = NodeState.Running;
        return state;
    }
}

