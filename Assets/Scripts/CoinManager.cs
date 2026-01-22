using UnityEngine;


public class CoinManager : MonoBehaviour
{

    private void Update()
    {
        AllCoinCollected();
    }
    public void AllCoinCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("todas las monedas recogidas");
        }
    }
}
