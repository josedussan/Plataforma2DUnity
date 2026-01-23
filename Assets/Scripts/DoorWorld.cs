using UnityEngine;
using TMPro;

public class DoorWorld : MonoBehaviour
{
    [SerializeField] LayerMask capasObjetivo;
    [SerializeField] LevelLoader sceneManager;
    [SerializeField] GameState state;
    [SerializeField] GameObject texto;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & capasObjetivo) == 0)
            return;
        if (state.llave)
        {
            state.llave = false;
            sceneManager.LoadScene("MenuPrincipal");
        }
        else
        {
            texto.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        texto.SetActive(false);
    }
}
