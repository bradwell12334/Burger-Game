using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the player touches this point
        if (other.CompareTag("Player"))
        {
            // Go to the next level
            SceneController.Instance.NextLevel1();
        }
    }
}
