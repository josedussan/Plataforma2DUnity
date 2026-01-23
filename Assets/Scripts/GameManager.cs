using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] GameState gameState;

    public UnityEvent<int> onMonedasChanged;
    public UnityEvent<int> onScoreChanged;
    public UnityEvent<int> onNivelChanged;
    public UnityEvent<int> onVidasChanged;
    public UnityEvent<bool> onLlaveChange;


    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateKey(bool estado)
    {
        gameState.llave = estado;
        onLlaveChange.Invoke(gameState.llave);
    }

    public void AddMoneda(int cantidad = 1)
    {
        gameState.monedas += cantidad;
        onMonedasChanged.Invoke(gameState.monedas);
    }

    public void AddScore(int puntos)
    {
        gameState.score += puntos;
        onScoreChanged.Invoke(gameState.score);
    }

    public void SetNivel(int nivel)
    {
        gameState.nivelActual = nivel;
        onNivelChanged.Invoke(gameState.nivelActual);
    }

    public void QuitVida()
    {
        gameState.vidas -= 1;
        if (gameState.vidas<1)
        {
            OnPlayerMuere();
        }
    }

    public void OnPlayerMuere()
    {
        // Decide el flujo, no la vida
        // Respawn, game over, reiniciar nivel
    }

    public GameState GetState() => gameState;
}
