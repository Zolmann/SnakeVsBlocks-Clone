using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void Play()
    {
        int NextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.GetSceneByBuildIndex(NextScene).IsValid()) // переписать с тернарным оператором
        {
            Debug.Log($"Играем {NextScene} уровень");
            SceneManager.LoadScene(NextScene);
        }
        else
        {
            Debug.Log("Вернулись на первый уровень");
            SceneManager.LoadScene(1);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        Debug.Log("Вышли из игры");
        Application.Quit();
    }
}
