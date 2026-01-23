using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SistemaVidas : MonoBehaviour
{
    [SerializeField] private int vida=5;
    [SerializeField] private string triggerDanio = "Danio";
    private Animator animator;
    public UnityEvent<int> onVidaChanged;
    public UnityEvent onMuerte;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void RecibirDanhio(int danhioRecibido)
    {
        vida -= danhioRecibido;
        onVidaChanged?.Invoke(vida);
        ActivarAnimacionDanio();
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = (Vector2.up * 25f);
        if (vida<=0)
        {
            onMuerte?.Invoke();
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
