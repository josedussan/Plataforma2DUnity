using System.Collections;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator anim;
    [Header("sistema de ataque")]
    [SerializeField] private GameObject attackHitCircle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        LanzarAtaque();
    }


    private void LanzarAtaque()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Atacar");
            StartCoroutine(Ataque());
        }
    }

    private IEnumerator Ataque()
    {
        attackHitCircle.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        attackHitCircle.SetActive(false);
    }
}
