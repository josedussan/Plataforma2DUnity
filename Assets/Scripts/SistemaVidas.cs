using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SistemaVidas : MonoBehaviour
{
    [SerializeField] private float vida=5;
    [SerializeField] private string triggerDanio = "Danio";
    private Animator animator;
    public UnityEvent<int> onVidaChanged;
    public UnityEvent onMuerte;
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
