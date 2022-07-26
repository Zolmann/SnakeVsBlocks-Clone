using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Play()
    {
        int NextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.GetSceneByBuildIndex(NextScene).IsValid()) // ���������� � ��������� ����������
        {
            Debug.Log($"������ {NextScene} �������");
            SceneManager.LoadScene(NextScene);
        }
        else
        {
            Debug.Log("��������� �� ������ �������");
            SceneManager.LoadScene(1);
        }
    }
}
