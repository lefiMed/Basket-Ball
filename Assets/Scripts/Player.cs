using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Ball ball;
    public GameObject cameraPlayer;
    public float ballDistance = 2.0f;
    public float throwingForce = 5f;

    public bool holdingBall = true;
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = cameraPlayer.transform.position + cameraPlayer.transform.forward * ballDistance;
        }
        
        if (Input.GetMouseButtonDown(0))
        {           
            holdingBall = false;
            ball.GetComponent<Rigidbody>().useGravity = true;
            ball.GetComponent<Rigidbody>().AddForce(cameraPlayer.transform.forward * throwingForce);
            ball.activateTrail();

        }
    }
}
