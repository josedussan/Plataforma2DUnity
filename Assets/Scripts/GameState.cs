using UnityEngine;

[CreateAssetMenu(menuName = "Game/Game State")]
public class GameState : ScriptableObject
{
    public int nivelActual;
    public int monedas;
    public int score;
    public int vidas;

    public void Reset()
    {
        nivelActual = 1;
        monedas = 0;
        score = 0;
        vidas = 5;
    }
}
