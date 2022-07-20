using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int auxDirection;
    private float speedPlayer;
    public float xMin;
    public float xMax;

    void Start()
    {
        speedPlayer = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMin, xMax), transform.position.y);

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
