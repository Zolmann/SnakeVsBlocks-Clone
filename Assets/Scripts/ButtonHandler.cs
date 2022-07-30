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
        if (NextScene < 3) // ���������� � ��������� ����������
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
    public void Restart()
    {
        Debug.Log("������ ������");
        SceneManager.LoadScene(NextScene - 1);
    }
    public void Quit()
    {
        Debug.Log("����� �� ����");
        Application.Quit();
    }
}
