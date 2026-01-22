using UnityEngine;

public class CausarDanio : MonoBehaviour
{
    [SerializeField] int danioAtaque=1;
    private SistemaVidas sistemaVidas;
    private DamageEffect de;
    [SerializeField] LayerMask capasObjetivo;

    public void Daniar(GameObject otro) {
        sistemaVidas = otro.GetComponent<SistemaVidas>();
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
}
