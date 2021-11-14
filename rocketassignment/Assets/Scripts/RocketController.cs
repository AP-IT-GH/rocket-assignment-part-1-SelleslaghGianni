using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private bool space = false;
    private bool left = false;
    private bool right = false;
    public float speed = 1f;
    public Rigidbody target;

    private void Update()
    {
        //Inputs
        space = Input.GetKey(KeyCode.Space);
        left = Input.GetKey(KeyCode.LeftArrow);
        right = Input.GetKey(KeyCode.RightArrow);

        //Change velocity or rotate the rocket
        if (space)
        {
            target.velocity = transform.up * speed * 5;
        }

        if (left)
        {
            transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime * speed, Space.World);
        }

        if (right)
        {
            transform.Rotate(new Vector3(0, 0, -50) * Time.deltaTime * speed, Space.World);
        }

        
    }
}