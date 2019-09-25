using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    public void switchScene()
    {
        if (sceneName == "Scene1")
        {
            SceneManager.LoadScene("Scene2");
        }
       
        else
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}
