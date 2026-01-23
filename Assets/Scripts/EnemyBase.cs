using System.Collections;
using UnityEngine;


public class EnemyBase : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    [SerializeField] float speed = 0.5f;
    [SerializeField] Transform[] moveSpots;
    private float waitTime;
    [SerializeField] float startWaitTime = 2;
    private int i = 0;
    private Vector2 actualPost;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CheckEnemyMoving());
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

    IEnumerator CheckEnemyMoving()
    {
        actualPost = transform.position;
        yield return new WaitForSeconds(0.5f);
        if (transform.position.x>actualPost.x)
        {
            spriteRenderer.flipX = true;
        }
        else if (transform.position.x < actualPost.x)
        {
            spriteRenderer.flipX = false;
        }
        else if (transform.position.x==actualPost.x)
        {

        }
    }
}
