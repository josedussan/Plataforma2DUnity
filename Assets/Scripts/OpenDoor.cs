using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject texto;
    [SerializeField] LevelLoader esceneManager;
    public string levelName;
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerHitBox"))
        {
            texto.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        texto.SetActive(false);
        inDoor = false;
    }

    private void Update()
    {
        if (Input.GetKey("e")&&inDoor)
        {
            esceneManager.LoadScene(levelName);
        }
    }
}
