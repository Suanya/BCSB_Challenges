using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMovement : MonoBehaviour
{
    //public float speed;

    //Vector3 mVelocity;


    float seconds;
    Vector3 begin;
    Vector3 end;
    Vector3 difference;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 2;

        begin = transform.position;
        end = new Vector3(11, 12, 13);
        difference = end - begin;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += difference * Time.deltaTime * seconds;
    }
}
