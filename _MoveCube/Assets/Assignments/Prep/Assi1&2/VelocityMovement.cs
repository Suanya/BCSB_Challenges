using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMovement : MonoBehaviour
{
    public float speed;

    Vector3 mVelocity;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mVelocity = Vector3.zero;

        // back and forth
        if (Input.GetKey(KeyCode.W))
        {
            mVelocity.z = 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            mVelocity.z = -1.0f;
        }

        // left and right
        if (Input.GetKey(KeyCode.D))
        {
            mVelocity.x = 1.0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            mVelocity.x = -1.0f;
        }

        transform.Translate(mVelocity * Time.deltaTime * speed);

    }
}
