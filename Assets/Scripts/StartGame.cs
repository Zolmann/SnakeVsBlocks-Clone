using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("������");
        SceneManager.LoadScene("Level 1");
    }
}
