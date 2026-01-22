using UnityEngine;

public class PlayerDeathHandler : MonoBehaviour
{
    SistemaVidas vidas;

    void Awake()
    {
        vidas = GetComponent<SistemaVidas>();
        vidas.onMuerte.AddListener(OnPlayerMuere);
    }

    void OnPlayerMuere()
    {
        GameManager.Instance.QuitVida();
    }
}
