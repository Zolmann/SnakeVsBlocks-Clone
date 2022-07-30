using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public int NextScene { get; private set; }
    private void Awake()
    {
        NextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }
    public void Play()
    {
        if (NextScene < 3) // переписать с тернарным оператором
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
        Debug.Log("Начали заново");
        SceneManager.LoadScene(NextScene - 1);
    }
    public void Quit()
    {
        Debug.Log("Вышли из игры");
        Application.Quit();
    }
}
