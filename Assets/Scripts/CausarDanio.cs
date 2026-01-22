using UnityEngine;

public class CausarDanio : MonoBehaviour
{
    [SerializeField] float danioAtaque=10f;
    private SistemaVidas sistemaVidas;
    private DamageEffect de;
    [SerializeField] LayerMask capasObjetivo;

    public void Daniar(GameObject otro) {
        sistemaVidas = otro.GetComponent<SistemaVidas>();
        de = otro.GetComponent<DamageEffect>();
        Debug.Log("entra aqui a daniar");
        if (sistemaVidas)
        {
            Debug.Log(otro.name+" "+ sistemaVidas.getVida());
            sistemaVidas.RecibirDanhio(danioAtaque);
            if (de)
            {
                de.FlashRojo(0.1f);
            }
            else
            {
                Debug.Log("no encuentra el damageEffect de: "+this.gameObject.name);
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
