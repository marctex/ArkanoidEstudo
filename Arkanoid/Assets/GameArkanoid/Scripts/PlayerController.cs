using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int auxDirection;
    private float speedPlayer;

    void Start()
    {
        speedPlayer = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (auxDirection != 0)
        {
            transform.Translate(auxDirection * speedPlayer * Time.deltaTime, 0, 0 );
        }
    }

    public void TouchHorizontal(int direction)
    {
        auxDirection = direction;
    }
}
