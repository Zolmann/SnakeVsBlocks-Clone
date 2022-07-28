using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Transform Player;
    public Stage Stage;
    public float Sensitivity;

    private void Update()
    {
        Player.position += Sensitivity * Time.deltaTime * Player.forward;
        if (Input.GetKey(KeyCode.LeftArrow))
        {         
            if (Player.position.x < Stage.Min_x) Player.position = new Vector3(Stage.Min_x, Player.position.y, Player.position.z) + Sensitivity * Time.deltaTime * Player.forward;
            else Player.position += Sensitivity * Time.deltaTime * -Player.right;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Player.position.x > Stage.Max_x) Player.position = new Vector3(Stage.Max_x, Player.position.y, Player.position.z) + Sensitivity * Time.deltaTime * Player.forward;
            else Player.position += Sensitivity * Time.deltaTime * Player.right;
        }
    }
}
