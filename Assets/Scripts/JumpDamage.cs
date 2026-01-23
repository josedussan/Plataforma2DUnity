using UnityEngine;

public class JumpDamage : MonoBehaviour
{
    private Collider2D coll;
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    [SerializeField] float jumpForce = 2.5f;
    [SerializeField] int lifes = 2;
    private DamageEffect de;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        coll = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        de = GetComponent<DamageEffect>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("entra al jumpDamage con: "+collision.gameObject.name);
        collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = (Vector2.up * jumpForce);
        LossLife();
    }

    public void LossLife() {
        lifes--;
        de.FlashRojo(0.1f);
        CheckLifes();
    }

    public void CheckLifes()
    {
        if (lifes==0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
