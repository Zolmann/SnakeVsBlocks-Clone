using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameLogic GameLogic;

    private void OnTriggerEnter(Collider other)
    {
        GameLogic.OnWin();
    }
}
