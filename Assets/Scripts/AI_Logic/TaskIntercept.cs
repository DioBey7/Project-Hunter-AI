using UnityEngine;
using System.Collections.Generic;

public class TaskIntercept : BTNode
{
    private Transform _transform;
    private Transform _target;
    private TargetTracker _targetTracker;
    private float _speed;
    private Pathfinding _pathfinding;
    private LineRenderer _lineRenderer;
    private GridManager _grid;
    
    private List<Vector3> _currentPath;
    private int _targetIndex;
    private float _pathUpdateTimer = 0f;
    private float _pathUpdateInterval = 0.15f;

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
        _pathUpdateTimer -= Time.deltaTime;

        if (_pathUpdateTimer <= 0f || _currentPath == null)
        {
            UpdatePath();
            _pathUpdateTimer = _pathUpdateInterval;
        }

        if (_currentPath != null && _targetIndex < _currentPath.Count)
        {
            Vector3 currentWaypoint = _currentPath[_targetIndex];
            
            _transform.position = Vector3.MoveTowards(_transform.position, currentWaypoint, _speed * Time.deltaTime);
            
            Vector3 direction = currentWaypoint - _transform.position;
            if (direction.magnitude > 0.1f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                _transform.rotation = Quaternion.Slerp(_transform.rotation, targetRotation, 8f * Time.deltaTime);
            }

            if (Vector3.Distance(_transform.position, currentWaypoint) < 0.6f)
            {
                _targetIndex++;
            }

            if (_lineRenderer != null)
            {
                int remainingNodes = _currentPath.Count - _targetIndex;
                if (remainingNodes > 0)
                {
                    _lineRenderer.positionCount = remainingNodes;
                    for (int i = 0; i < remainingNodes; i++)
                    {
                        _lineRenderer.SetPosition(i, _currentPath[i + _targetIndex]);
                    }
                }
                else
                {
                    _lineRenderer.positionCount = 0;
                }
            }

            state = NodeState.Running;
            return state;
        }

        state = NodeState.Success;
        return state;
    }

    private void UpdatePath()
    {
        float distance = Vector3.Distance(_transform.position, _target.position);
        
        Vector3 targetPoint;
        if (distance < 3f) 
        {
            targetPoint = _target.position;
        }
        else 
        {
            float timeToIntercept = distance / _speed;
            targetPoint = _target.position + (_targetTracker.Velocity * timeToIntercept);
        }

        Node targetNode = _grid.NodeFromWorldPoint(targetPoint);
        targetPoint = targetNode.worldPosition;

        _currentPath = _pathfinding.FindPath(_transform.position, targetPoint);
        _targetIndex = 0;
        
        if (_currentPath != null && _currentPath.Count > 0)
        {
            if (Vector3.Distance(_transform.position, _currentPath[0]) < 0.5f)
            {
                _targetIndex = 1;
            }
        }
    }
}
