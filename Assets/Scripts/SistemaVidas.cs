using System.Collections;
using UnityEngine;

public class SistemaVidas : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private string triggerDanio = "Danio";
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void RecibirDanhio(float danhioRecibido)
    {
        vida -= danhioRecibido;
        ActivarAnimacionDanio();
        if (vida<=0)
        {
            Destroy(this.gameObject);
        }
    }

    void ActivarAnimacionDanio()
    {
        if (animator != null && !string.IsNullOrEmpty(triggerDanio))
        {
            animator.SetTrigger(triggerDanio);
        }
    }

    public float getVida()
    {
        return vida;
    }
}
