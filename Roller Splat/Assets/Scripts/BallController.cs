using UnityEngine;

public class BallController : MonoBehaviour
{
    public static BallController instance;
    public Rigidbody rb;
    public Material[] Colors;



    public void Start()
    {
        instance = this;
    }
    public void Update()
    {
        if (SwipeManager.instance.swipeDirection == "Up")
        {
            rb.velocity = Vector3.forward * 15;
        }

        if (SwipeManager.instance.swipeDirection == "Down")
        {
            rb.velocity = Vector3.back * 15;
        }

        if (SwipeManager.instance.swipeDirection == "Right")
        {
            rb.velocity = Vector3.right * 15;
        }

        if (SwipeManager.instance.swipeDirection == "Left")
        {
            rb.velocity = Vector3.left * 15;
        }
    }
    public void RandomColor()
    {
        int randomNumber = Random.Range(0, Colors.Length);
        Debug.Log(randomNumber);
        foreach (BallController ball in GameObject.FindObjectsOfType<BallController>())
        {
            ball.GetComponent<Renderer>().material = new Material(Colors[randomNumber]);
        }
    }
}