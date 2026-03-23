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
        Vector3 rawVelocity = (transform.position - _lastPosition) / Time.deltaTime;
        Velocity = Vector3.Lerp(Velocity, rawVelocity, 15f * Time.deltaTime);
        _lastPosition = transform.position;
    }
}
