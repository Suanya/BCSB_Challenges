using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DebriClickSecond : MonoBehaviour
{
    public GameObject cube;
    public GameObject debriCube;
    public int numberOfDebriCubes;

    /*
    [SerializeField] private float velocity;
    //[SerializeField] private float position;
    [SerializeField] private float gravity;
    [SerializeField] private float acceleration;
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            cube.SetActive(false);
            Debug.Log("cubeClick and set to false");

            for(int i = 0; i < 10; i++)
            {
                GameObject go = Instantiate(debriCubes, PositionDebriCubes(), Quaternion.identity);
                go.GetComponent<Rigidbody>().AddForce(PositionDebriCubes() * 1);
            }

            
        }
    }

    Vector3 PositionDebriCubes()
    {
        float xPos = Random.Range(0.90f, -0.90f);
        float yPos = Random.Range(0.1f, 0.1f);
        float zPos = Random.Range(0.90f, -0.90f);

        return new Vector3(xPos, yPos, zPos);
    }
    /*

    /*
        position += velocity;
        velocity += acceleration;
        acceleration = gravity;
        */

    
}
