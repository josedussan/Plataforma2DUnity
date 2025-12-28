using System.Collections;
using UnityEngine;

public class WormScript : MonoBehaviour
{
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private float velocidad=5;
    private Vector3 destinoActual;
    private int indiceActual=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destinoActual = wayPoints[indiceActual].position;
        StartCoroutine(Patrulla());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Patrulla() {
        while (true) {
            while (transform.position != destinoActual)
            {
               transform.position= Vector3.MoveTowards(transform.position, destinoActual, velocidad * Time.deltaTime);
                yield return null;
            }
            NuevoDestino();
        } 
    }

    private void NuevoDestino() {
        indiceActual++;
        if (indiceActual>=wayPoints.Length)
        {
            indiceActual = 0;
        }
        destinoActual = wayPoints[indiceActual].position;
        EnfocarDestino();
    }

    private void EnfocarDestino()
    {

        if (destinoActual.x<transform.position.x)
        {
            transform.localScale = Vector3.one;
        }
        else
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }

    
}
