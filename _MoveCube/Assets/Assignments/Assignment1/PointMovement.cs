using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    public GameObject[] checkPoints; // array of gameobjects, the cube will be attracted to
    int current = 0; // shows which checkPoint we're currently heading to
    public float[] speed; // indicates how fast the cube is moving
    float CPradius = 1; // if cube is in this radius, it knows it's there (in case we use emtpy space instead of trees)
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(checkPoints[current].transform.position, transform.position) < CPradius) // checking distance between checkPoints and if it's less tha the CPRadius, this happens:
        {
            current++; // adds on the current value if CPradius is < 1
            if (current >= checkPoints.Length) // if >= we reached all checkPoints and go back to start
            {
                current = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, checkPoints[current].transform.position, Time.deltaTime * speed[current]); // moves the object from the current position to the target position in a specific speed      
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
