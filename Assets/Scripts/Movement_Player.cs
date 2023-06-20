using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public float ballForce;
    public Rigidbody ball;
    public float keyInput;
    // Start is called before the first frame update
    void Start()
    {
        ball =  GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            ball.AddForce(-keyInput, 0f, 0f);
        }
        if (Input.GetKey("d"))
        {
            ball.AddForce(keyInput, 0f, 0f);
        }

        //keyinput = Input.GetAxis("Horizontal");
        //ball.velocity = new Vector3 (keyinput*5, ball.velocity.y, 10);
        ball.AddForce(0f, 0f, ballForce);
    }
}
