using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shaker : MonoBehaviour
{
    public float m_shakeDuration = 0.5f ;
    public float m_shakeStrength = 0.1f;
    public int m_vibrato = 1;
    public float m_shakeRandomness = 90;
    public bool m_shakeFadeOut = true;

    public void Shake()
    {
        transform.DOShakePosition(m_shakeDuration, m_shakeStrength, m_vibrato, m_shakeRandomness, false, true);
        Debug.Log("it's shaking");
    }

}
