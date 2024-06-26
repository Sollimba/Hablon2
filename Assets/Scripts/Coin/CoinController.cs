using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private int points = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EventManager.RaiseAddPoints(points);
            EventManager.RaiseCoinCollected();
            Destroy(gameObject);
        }
    }
}
