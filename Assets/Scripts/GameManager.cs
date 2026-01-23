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
        onVidasChanged.Invoke(gameState.vidas);
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

    public void Reiniciar()
    {
        gameState.monedas =0;
        onMonedasChanged.Invoke(gameState.monedas);
        gameState.vidas =5;
        onVidasChanged.Invoke(gameState.vidas);
        gameState.llave = false;
        onLlaveChange.Invoke(gameState.llave);
    }

    public GameState GetState() => gameState;
}
