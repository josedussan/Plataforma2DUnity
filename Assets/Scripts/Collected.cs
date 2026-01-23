using UnityEngine;

public class Collected : MonoBehaviour
{
    [SerializeField] AudioSource asource;
    [SerializeField] AudioClip clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerHitBox"))
        {
            GameManager.Instance.AddMoneda();
            asource.PlayOneShot(clip);
            Destroy(gameObject, 0.2f);
        }
        
    }
}
