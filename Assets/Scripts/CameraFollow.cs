using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    // Distance the camera keeps from the target
    private Vector3 distanceFromTarget;
    // Time it takes for the camera to catch up smoothly
    private float followSmoothness = 0.25f;
    // Current speed of the camera's movement
    private Vector3 currentVelocity = Vector3.zero;

    // The object that the camera will be following
    [SerializeField] private Transform player;

    private void Start()
    {
        // Initialize the distance to keep the camera behind the player
        distanceFromTarget = new Vector3(0f, 0f, -10f);
    }

    private void Update()
    {
        // Calculate the desired camera position based on the player's position
        Vector3 desiredPosition = player.position + distanceFromTarget;

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, followSmoothness);
    }
}
