using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    private Vector3 _lastPosition;
    public Vector3 Velocity { get; private set; }

    void Start()
    {
        _lastPosition = transform.position;
    }

    void Update()
    {
        Velocity = (transform.position - _lastPosition) / Time.deltaTime;
        _lastPosition = transform.position;
    }
}
