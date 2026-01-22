using System.Collections;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        originalColor = sprite.color;
    }
    public void FlashRojo(float duracion) {
        StartCoroutine(FlashRoutine(duracion));
    }

    private IEnumerator FlashRoutine(float duracion)
    {
        sprite.material.color = Color.red;
        yield return new WaitForSeconds(duracion);
        sprite.material.color = originalColor;
    }

}
