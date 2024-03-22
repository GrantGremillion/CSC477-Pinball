using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    public float launchForce;
    public Transform ballStart;
    public Transform ballEnd;
    public GamePlay gameScript;
    public HandleUI ui;
    
    private float distanceToReset;
    private float x_limit = 6f;
    private float z_limit = 4f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        distanceToReset = ballEnd.GetComponent<SphereCollider>().radius;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, ballEnd.position) < distanceToReset) 
        {
            ResetBall();
            gameScript.lives -= 1;

            if (gameScript.lives < 1)
            {
                ui.endGame();
                gameScript.gameHasStarted = false;
            }

            
        }

        if (transform.position.x < x_limit && gameScript.readyToLaunch)
        {
            gameScript.enableBlockingWall();
            gameScript.readyToLaunch = false;
        }

        if (transform.position.x > x_limit && transform.position.z < z_limit)
        {
            gameScript.disableBlockingWall();
            gameScript.readyToLaunch = true;
        }
    }

    public void Launch()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }

    public void ResetBall()
    {
        transform.position = ballStart.transform.position;
        rb.velocity = Vector3.zero;
        gameScript.readyToLaunch = true;
        gameScript.disableBlockingWall();
        gameScript.scorePerTick = gameScript.defaultScorePerTick;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (!gameScript.readyToLaunch)
        {
            if (collision.transform.tag == "Anchor")
                gameScript.score += 500;
        }
        
            
    }

}
