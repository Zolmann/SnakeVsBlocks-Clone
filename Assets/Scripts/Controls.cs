using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody Player;
    public Stage Stage;
    public float Speed;

    private void Update()
    {
        Player.velocity = new Vector3 (0, 0, Speed);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.velocity += new Vector3(-Speed, 0, 0);
            if (Player.position.x < Stage.Min_x) Player.position = new Vector3(Stage.Min_x, Player.position.y, Player.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.velocity += new Vector3 (Speed, 0, 0);
            if (Player.position.x > Stage.Max_x) Player.position = new Vector3(Stage.Max_x, Player.position.y, Player.position.z);
        }
    }
}
