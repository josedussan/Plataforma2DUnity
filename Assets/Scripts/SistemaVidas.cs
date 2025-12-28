using UnityEngine;

public class SistemaVidas : MonoBehaviour
{
    [SerializeField] private float vida;
    
    public void RecibirDanhio(float danhioRecibido)
    {
        vida -= danhioRecibido;
        if (vida<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
