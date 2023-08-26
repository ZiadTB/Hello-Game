using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RafLevel : MonoBehaviour
{
    public int sceneBuildIndex;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TRIGGER ENTERED!!!");
            if(collision.tag == "Player")
            {
                
                Debug.Log("COLLISION BITCHES");
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
    }

}
