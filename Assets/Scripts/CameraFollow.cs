using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 0, 0);
    void Update()
    {
        transform.position = new Vector3 (5f, target.position.y, target.position.z) + offset;       
    }
}
