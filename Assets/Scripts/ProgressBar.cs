using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public SnakeBlock SnakeBlock;
    public Transform Finish;
    public Slider Slider;
    private float _startPos;

    private void Start()
    {
        _startPos = SnakeBlock.transform.position.z;
    }
    private void Update()
    {
        float finish = Finish.transform.position.z;
        float part = Mathf.InverseLerp(_startPos, finish, SnakeBlock.transform.position.z);
        Slider.value = part;
    }
}
