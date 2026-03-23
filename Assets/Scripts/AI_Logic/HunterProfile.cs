using UnityEngine;

[CreateAssetMenu(fileName = "NewHunterProfile", menuName = "AI/Hunter Profile")]
public class HunterProfile : ScriptableObject
{
    public float baseSpeed = 5f;
    public float fovRadius = 8f;
    [Range(0, 360)] public float fovAngle = 90f;
    public float baseHearingRange = 5f;
    public float catchRadius = 1.2f;
    
    public AudioClip patrolSound;
    public AudioClip chaseSound;
    public AudioClip catchSound;
    
    public float minAudioPitch = 0.8f;
    public float maxAudioPitch = 1.3f;
}