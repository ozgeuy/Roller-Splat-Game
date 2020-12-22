using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public static Plane instance;
    public GameObject Ball;
    public bool PlaneChangeColor;

    public void Start()
    {
        instance = this;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Plane" && collision.collider.tag == "Player")
        {
            GetComponent<Renderer>().material = Ball.GetComponent<Renderer>().material;
            gameObject.tag = "Untagged";
            LevelManager.instance.LevelControl();
        }
    }
}
