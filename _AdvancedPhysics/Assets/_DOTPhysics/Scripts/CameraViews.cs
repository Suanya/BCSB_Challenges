using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraViews : MonoBehaviour
{
    

    public void MoveCamera(Transform view)
    {
        transform.DOMove(view.position, 1).SetEase(Ease.OutElastic);
        transform.DORotate(view.eulerAngles, 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
