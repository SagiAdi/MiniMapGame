using UnityEngine;

/// <summary>
/// Keeps the camera centered on a target, preserving the camera's Z position.
/// </summary>
public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position;
        transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
    }
}