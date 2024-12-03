using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value;
    [SerializeField] private int amount;
    [SerializeField] private int fee;
    [SerializeField] private int price;
    [SerializeField] private int quantity;
    private bool hasTriggered;

    private CoinManager coinManager;

    private void Start()
    {
        coinManager = CoinManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            coinManager.ChangeCoins(value);
            Destroy(gameObject);

        }
    }
}
