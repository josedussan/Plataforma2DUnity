using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] LevelLoader sceneManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LlamarPanel(RectTransform panel) {
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
        sceneManager.LoadScene("MenuPrincipal");
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    void PararJuego(int num)
    {
        Time.timeScale = num;
    }
}
