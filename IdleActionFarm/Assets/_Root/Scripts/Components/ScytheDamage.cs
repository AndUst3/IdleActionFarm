using UnityEngine;

public class ScytheDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Grass"))
        {
            if (Main.pointsCount < 40) 
            {
                Main.pointsCount++;
                GlobalEvents.GrassEffect?.Invoke();
                other.gameObject.SetActive(false);
            }

            else
            {
                other.gameObject.SetActive(true);
            }
        }
    }
}
