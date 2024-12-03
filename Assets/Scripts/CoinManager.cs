using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
   

    private int coins;
    [SerializeField] private TMP_Text coinDisplay;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    private void OnGUI()
    {
        coinDisplay.text = coins.ToString();
    }
    public void ChangeCoins(int amount)
    {
        coins += amount;
    }
}