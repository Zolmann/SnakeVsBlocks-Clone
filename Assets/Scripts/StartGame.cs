using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Play()
    {
        int NextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.GetSceneByBuildIndex(NextScene).IsValid()) // переписать с тернарным оператором
        {
            Debug.Log($"»граем {NextScene} уровень");
            SceneManager.LoadScene(NextScene);
        }
        else
        {
            Debug.Log("¬ернулись на первый уровень");
            SceneManager.LoadScene(1);
        }
    }
}
