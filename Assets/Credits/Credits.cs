using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadLevel(0));

        IEnumerator LoadLevel(int levelIndex)
        {
            transition.SetTrigger("Start");

            yield return new WaitForSeconds(23);

            SceneManager.LoadScene(0);
        }
    }
}
