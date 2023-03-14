using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Main.pointsCount > 0)
            {
                Main.coinsCount += Main.pointsCount * 15;
                Main.pointsCount = 0;
                GlobalEvents.CoinsEffect?.Invoke();
            }
        }
    }
}
