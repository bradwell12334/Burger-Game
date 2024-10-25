using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance; // This allows other scripts to access CoinManager

    private int coins = 0; // Start with 0 coins
    [SerializeField] private TMP_Text coinsDisplay; // Text object to show coins

    private void Awake()
    {
        // Check if the instance is not set, then set it
        if (instance == null)
        {
            instance = this; // Set this as the instance
            DontDestroyOnLoad(gameObject); // Keep this object when changing scenes
        }
        else
        {
            Destroy(gameObject); // Destroy if there is already an instance
        }
    }

    private void Update()
    {
        // Update the coin display every frame
        if (coinsDisplay != null) // Make sure coinsDisplay is set
        {
            coinsDisplay.text = coins.ToString(); // Show the coins as text
        }
    }

    public void ChangeCoins(int amount)
    {
        coins += amount; // Add or subtract coins based on amount
        UpdateDisplay(); // Update the display after changing coins
    }

    private void UpdateDisplay()
    {
        if (coinsDisplay != null)
        {
            coinsDisplay.text = coins.ToString(); // Show updated coins
        }
    }
}
