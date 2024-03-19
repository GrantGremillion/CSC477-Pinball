using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    public float launchForce;
    public Transform ballStart;
    public Transform ballEnd;
    public GamePlay gameScript;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, ballEnd.position) < 1.5) 
        {
            ResetBall();
        }

        if (transform.position.x < 6 && gameScript.readyToLaunch)
        {
            gameScript.enableBlockingWall();
            gameScript.readyToLaunch = false;
        }
    }

    public void Launch()
    {
        rb.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }

    public void ResetBall()
    {
        transform.position = ballStart.transform.position;
        rb.velocity = Vector3.zero;
        gameScript.readyToLaunch = true;
        gameScript.disableBlockingWall();
        gameScript.scorePerTick = 100;
    }

}
