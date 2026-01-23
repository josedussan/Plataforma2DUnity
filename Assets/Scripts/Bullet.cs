using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed=2f;
    [SerializeField] float lifeTime=3f;
    [SerializeField] bool left;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject,lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            transform.Translate(Vector2.left*speed*Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
