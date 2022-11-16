using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeSquence : MonoBehaviour
{
    public GameObject[] cubes;

    // Start is called before the first frame update
    void Start()
    {
        var seq = DOTween.Sequence();

       

        foreach(GameObject cube in cubes)
        {
            //seq.Append(cube.transform.DOScale(Vector3.zero, .3f).From().SetEase(Ease.OutElastic)) ;
        }

        for(int i = 0; i < cubes.Length; i++)
        {
            cubes[i].transform.DOScale(Vector3.zero, .3f).From().SetEase(Ease.OutElastic).SetDelay(0.2f * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
