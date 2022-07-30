using UnityEngine;

public class SnakeBlock : MonoBehaviour
{
    public void ChangeSize(int delta)
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + delta / 4f, transform.localScale.z);
        if (transform.localScale.y < 1) transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
