using UnityEngine;

public class CausarDanio : MonoBehaviour
{
    [SerializeField] int danioAtaque=1;
    private SistemaVidas sistemaVidas;
    private DamageEffect de;
    [SerializeField] float jumpForce=5;
    [SerializeField] LayerMask capasObjetivo;

    public void Daniar(GameObject otro) {
        sistemaVidas = otro.GetComponent<SistemaVidas>();
        float direccionX =otro.GetComponent<SpriteRenderer>().flipX ? 1f : -1f;
        otro.gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(direccionX * jumpForce, otro.gameObject.GetComponent<Rigidbody2D>().linearVelocityY);
        de = otro.GetComponent<DamageEffect>();
        if (sistemaVidas)
        {
            sistemaVidas.RecibirDanhio(danioAtaque);
            if (de)
            {
                de.FlashRojo(0.1f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & capasObjetivo) == 0)
            return;
        Daniar(other.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (((1 << other.gameObject.layer) & capasObjetivo) == 0)
            return;
        Daniar(other.gameObject);
    }
}
