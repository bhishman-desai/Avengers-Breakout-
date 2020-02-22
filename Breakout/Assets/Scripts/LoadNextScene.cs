using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextScene1()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        Scene cs = SceneManager.GetActiveScene();
        string sceneName = cs.name;

        if (sceneName == "End Game")
        {
            SceneManager.LoadScene(0);
        }
        else
            SceneManager.LoadScene(currentScene + 1);
    }

    public void closeGame()
    {
        Application.Quit();
    }
}
