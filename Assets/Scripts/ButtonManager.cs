using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] LevelLoader sceneManager;
    [SerializeField] AudioSource asource;
    [SerializeField] AudioClip clip;


    public void LlamarPanel(RectTransform panel) {
        PlaySound();
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
        PlaySound();
        sceneManager.LoadScene("MenuPrincipal");
    }

    public void CerrarJuego()
    {
        PlaySound();
        Application.Quit();
    }

    void PararJuego(int num)
    {
        Time.timeScale = num;
    }

    void PlaySound()
    {
        asource.PlayOneShot(clip);
    }
}
