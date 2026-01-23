using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] TextMeshProUGUI monedasText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI nivelText;
    [SerializeField] List<Image> vidas;
    [SerializeField] List<Sprite> spriteVidas,spriteLlave;
    [SerializeField] Image llave;
    void Start()
    {
        var gm = GameManager.Instance;

        // Inicializar valores al entrar
        monedasText.text = gm.GetState().monedas.ToString();
        scoreText.text = gm.GetState().score.ToString();
        nivelText.text = gm.GetState().nivelActual.ToString();


        // Suscribirse a eventos
        gm.onMonedasChanged.AddListener(UpdateMonedas);
        gm.onScoreChanged.AddListener(UpdateScore);
        gm.onNivelChanged.AddListener(UpdateNivel);
        gm.onVidasChanged.AddListener(UpdateVidas);
        gm.onLlaveChange.AddListener(UpdateLlave);
    }

    void UpdateMonedas(int valor)
    {
        monedasText.text = valor.ToString();
    }

    void UpdateLlave(bool condicion)
    {
        if (condicion)
        {
            llave.sprite = spriteLlave[0];
        }
        else
        {
            llave.sprite = spriteLlave[0];
        }
        
    }

    void UpdateScore(int valor)
    {
        scoreText.text = valor.ToString();
    }

    void UpdateNivel(int valor)
    {
        nivelText.text = valor.ToString();
    }

    void UpdateVidas(int valor) {
        vidas[valor - 1].sprite = spriteVidas[1];
    }
}
