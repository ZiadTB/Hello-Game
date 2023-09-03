using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] private float delay = 20f;

    [SerializeField] private int SceneName = 0;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        
        if(timeElapsed > delay)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
