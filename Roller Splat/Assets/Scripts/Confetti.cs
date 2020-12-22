using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public static Confetti instance;

    public void Start()
    {
        instance = this;
    }

    public void Play()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
    }
}