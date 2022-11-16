using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is attached to the debriCubePrefab and makes it "explode", it gives the debriCubes some action!
/// </summary>

public class DebriMove : MonoBehaviour
{
    public Transform explodingDebriTransform;

    public float destroyDebriTime;
    public float randomAxis;

    private void Start()
    {
        explodingDebriTransform = this.explodingDebriTransform.transform.GetComponent<Transform>();
    }

    void Update()
    {
        Exploison();
    }

    void Exploison()//send the particles towards a random range
    {
        float xPos = Random.Range(randomAxis, -randomAxis);
        float yPos = Random.Range(randomAxis, -randomAxis);
        float zPos = Random.Range(randomAxis, -randomAxis);

        transform.Translate(xPos, yPos, zPos);

        explodingDebriTransform.localScale -= new Vector3(.005f, .005f, .005f);

        if (explodingDebriTransform.localScale.z <= 0)
        {
            explodingDebriTransform.localScale = new Vector3(.0f, .0f, .0f);

        }
        Destroy(this.gameObject, destroyDebriTime);
    }
}





