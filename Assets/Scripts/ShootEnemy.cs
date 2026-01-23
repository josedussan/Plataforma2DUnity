using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    private float waitedTime;
    [SerializeField] float waitTimeToAttack = 2f;
    private Animator anim;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform spawnBulletPoint;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waitedTime = waitTimeToAttack;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitedTime<=0)
        {
            waitedTime = waitTimeToAttack;
            anim.SetTrigger("Attack");
            LaunchBullet();
        }
        else
        {
            waitedTime -= Time.deltaTime;
        }
    }

    void LaunchBullet()
    {

        GameObject bullet= Instantiate(bulletPrefab,spawnBulletPoint.position,spawnBulletPoint.rotation);
    }
}
