using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private Collider2D coll;
    private Animator anim;
    [SerializeField] float jumpForce=30f;
    [SerializeField] AudioSource asource;
    [SerializeField] AudioClip clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = (Vector2.up * jumpForce);
        anim.SetTrigger("Jump");
        asource.PlayOneShot(clip);
    }
}
