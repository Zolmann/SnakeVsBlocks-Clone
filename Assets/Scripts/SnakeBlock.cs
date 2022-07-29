using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBlock : MonoBehaviour
{
    public void ChangeSize(int delta)
    {
        if (transform.localScale.y > 1f)
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + delta / 4f, transform.localScale.z);
    }
}
