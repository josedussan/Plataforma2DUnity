using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] Transform[] moveSpots;
    private float waitTime;
    [SerializeField] float startWaitTime = 2;
    private int i = 0;


    private void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                if (moveSpots[i] != moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
