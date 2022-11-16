using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerDown : MonoBehaviour
{
    [SerializeField] private BoxCollider boxCollider;
    [SerializeField] private Animator shaker;

    private void OnCollissionEnter(Collision collission)
    {
        if (!collission.gameObject.CompareTag("Hammer"))
            return;
        Debug.Log("ball hit");

        var position = transform.position + boxCollider.size.y / 2 * Vector3.up;
        var halfExtents = Vector3.Scale(transform.lossyScale, boxCollider.size) / 2;
        var layerMask = LayerMask.GetMask("ShakeIt");
        Debug.Log(LayerMask.GetMask());

        var colliders = Physics.OverlapBox(position, halfExtents, transform.rotation, layerMask);
        Debug.Log("phyicsTouch");

        foreach(var other in colliders)
        {
            Debug.Log("var in colliders");
            other.GetComponent<Animator>().SetTrigger("ShakeTest");

            Debug.Log("Shake");
        }

    }
}
