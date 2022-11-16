using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CubeAnim : MonoBehaviour
{
    /*
    public float m_shakeDuration;
    public float[] m_shakeStrength;
    public int[] m_vibrato;
    public float[] m_shakeRandomness;
    public bool m_shakeFadeOut = true;
    */

    public Transform fan;
   

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0), 3).SetDelay(2).From().SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);

        fan.DORotate(new Vector3(180, 0, 0), 0.5f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);

        //transform.DOShakeRotation(m_shakeDuration, m_shakeStrength, m_vibrato, m_shakeRandomness, m_shakeFadeOut);

    }

    
}


/*
 * simple move with delay
 * void Start()
 * {
 *      transform.DOMove(new Vector3(1, 1, 1), 3).SetDelay(2);
 * }
 * 
 */