using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] LevelLoader sceneManager;
    [SerializeField] AudioSource asource;
    [SerializeField] AudioClip clip;


    public void LlamarPanel(RectTransform panel) {
        ReproducirSonido();
        if (!panel.gameObject.activeSelf)
        {
            PararJuego(0);
        }
        else
        {
            PararJuego(1);
        }
        
        panel.gameObject.SetActive(!panel.gameObject.activeSelf);
    }

    public void IrMenuPrincipal()
    {
        PararJuego(1);
        ReproducirSonido();
        sceneManager.LoadScene("MenuPrincipal");
    }

    public void CerrarJuego()
    {
        ReproducirSonido();
        Application.Quit();
    }

    void PararJuego(int num)
    {
        Time.timeScale = num;
    }

    void ReproducirSonido()
    {
        asource.PlayOneShot(clip);
    }
}
