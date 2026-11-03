using UnityEngine;

/// <summary>
/// Keeps the camera's visible world width constant, so objects keep the same
/// size relative to the screen width when the device is rotated.
/// Visible width = 2 * orthographicSize * aspect, so when the aspect ratio
/// changes (portrait / landscape) we recompute the size to keep the width.
/// </summary>
[RequireComponent(typeof(Camera))]
public class CameraWidthFitter : MonoBehaviour
{
    [Tooltip("Visible world width, in world units")]
    [SerializeField] private float desiredWorldWidth = 22f;

    // orthographicSize is half of the visible extent
    private const float HalfFactor = 2f;

    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        cam.orthographicSize = desiredWorldWidth / (HalfFactor * cam.aspect);
    }
}