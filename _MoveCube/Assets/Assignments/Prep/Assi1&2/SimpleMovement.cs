using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // back and forth
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -speed * Time.deltaTime);
        }

        // left and right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f);
        }

    }
}


// base moving forward
/*
 * Update()
 * {
 *       transform.position += transform.forward * Time.deltaTime
 * }  
 * 
 */

