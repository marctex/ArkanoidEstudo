using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

{
    public float speedBall;
    public Rigidbody2D oRigidbody2D;
    public bool checkStart;

    void Start()
    {

    }  
        

    void Update()
    {
        if (checkStart == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                MoveBall();
                checkStart = true;
            }
        }
    }

    private void MoveBall()
    {
        oRigidbody2D.velocity = Vector2.up * speedBall;
    }
}
