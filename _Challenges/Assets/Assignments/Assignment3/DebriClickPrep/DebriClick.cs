using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DebriClick : MonoBehaviour
{
    public GameObject cube;
    public GameObject debriCubes;
    public int numberOfDebriCubes;

    /*
    [SerializeField] private float velocity;
    [SerializeField] private float position;
    [SerializeField] private float gravity;
    [SerializeField] private float acceleration;
    */

   
    // Start is called before the first frame update
    public void Start()
    {
        /*
        position += velocity;
        velocity += acceleration;
        acceleration = gravity;
        */       

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            cube.SetActive(false);
            Debug.Log("cubeClick and set to false");

            // PositionDebriCubes();
            // Debug.Log("DebrisPosition");

            InstantiateDebriCubes();
            Debug.Log("DebrisGO");

            //DebriExpolsion();
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
    private void DebriExpolsion()
    {
        float xPos = Random.Range(0.90f, -0.90f);
        float yPos = Random.Range(0.1f, 0.1f);
        float zPos = Random.Range(0.9f, -0.90f);

        transform.position = new Vector3(xPos, yPos, zPos);
    }
    */

    private void InstantiateDebriCubes()
    {
        for (int i = 0; i < numberOfDebriCubes; i++)
        {
            Instantiate(debriCubes, PositionDebriCubes(), Quaternion.identity);
        }
    }
}
