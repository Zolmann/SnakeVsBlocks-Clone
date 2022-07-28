using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int HP = 5;
    void Update()
    {
        if (HP < 0) Debug.Log("It's dead");
    }
}
