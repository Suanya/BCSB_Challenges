using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script makes the EntranceCube disappear and initiat many smaller debriCubes instead with random position
/// </summary>

public class DebriTest : MonoBehaviour
{
    public GameObject cube;
    public GameObject debriCubes;
    public int numberOfDebriCubes;

    // Start is called before the first frame update
    public void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cube.SetActive(false);
            InstantiateDebriCubes();
            Debug.Log("Cube was clicked: " + Input.GetMouseButtonDown(0));
        }
    }

    Vector3 PositionDebriCubes()
    {
        float xPos = Random.Range(0.90f, -0.90f) ;
        float yPos = Random.Range(0.1f, 0.1f);
        float zPos = Random.Range(0.90f, -0.90f) ;

        return new Vector3(xPos, yPos, zPos);
    }

    private void InstantiateDebriCubes()
    {
        for (int i = 0; i < numberOfDebriCubes; i++)
        {
            Instantiate(debriCubes, PositionDebriCubes(), Quaternion.identity);
        }
    }
}
