using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] Animator transicion;
    public void LoadScene(string scene)
    {
        StartCoroutine(LoadLevel(scene));
    }

    IEnumerator LoadLevel(string scene)
    {
        transicion.SetTrigger("Start");

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scene);
    }

}
