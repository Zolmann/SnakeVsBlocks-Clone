using UnityEngine;

public class Exit : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Вышли из игры");
        Application.Quit();
    }
}
