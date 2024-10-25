using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value; // The value of the coin
    private bool hasTriggered = false; // To check if the coin has been collected

    private CoinManager coinManager; // Reference to the CoinManager

    private void Start()
    {
        coinManager = CoinManager.instance; // Get the CoinManager instance

        // Check if CoinManager is set up correctly
        if (coinManager == null)
        {
            Debug.LogError("CoinManager is not set up! Please check the scene.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object that collided is the Player and if the coin hasn't been collected yet
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true; // Mark the coin as collected

            // If coinManager is not null, add the coin value
            if (coinManager != null)
            {
                coinManager.ChangeCoins(value); // Add the coin value to the total
            }
            else
            {
                Debug.LogError("CoinManager is still null when trying to add coins.");
            }

            Destroy(gameObject); // Remove the coin from the scene
        }
    }
}
