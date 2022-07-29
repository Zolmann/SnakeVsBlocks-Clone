using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameLogic GameLogic;
    public int HP = 5;
    public TMP_Text Lives;
    void Update()
    {
        Lives.text = HP.ToString();
        if (HP <= 0) GameLogic.OnDeath();
    }
}
