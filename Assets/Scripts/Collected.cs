using UnityEngine;

public class Collected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerHitBox"))
        {
            Destroy(gameObject, 0.2f);
        }
        
    }
}
