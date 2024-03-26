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
    public Transform inCannon;
    public Transform aimFor;
    public Transform outCannon;
    public GamePlay gameScript;
    public HandleUI ui;
    public GameObject soundManager;
    public GameObject cannon;
    public ParticleSystem cannonFlame;
    public Target target;
    public TargetTracker targetTracker;
    
    private float distanceToReset;
    private float distanceToLaunch = 1.5f;
    private float x_limit = 3.14f;
    private float x_limit2 = 5.61f;
    private float z_limit = 8.27f;

    private int anchorScore = 500;
    private int targetScore = 1000;
    private int pointCircleScore = 2000;


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
            gameScript.resetBallTimer();
            gameScript.lives -= 1;
            GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i].GetComponent<Target>().triggered = false;
            }

            if (gameScript.lives < 1)
            {
                gameScript.gameOver();
            }
        }

        checkReadyToLaunch();
    }

    public void Launch()
    {
        rb.velocity = Vector3.zero;
        transform.position = outCannon.position;

        Vector3 dirr = Vector3.Normalize(aimFor.position - transform.position);

        rb.AddForce(dirr * launchForce, ForceMode.Impulse);
        soundManager.GetComponent<SoundEffects>().playSoundCannon();
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
        if (collision.transform.tag == "Anchor")
        {
            gameScript.score += anchorScore;
            soundManager.GetComponent<SoundEffects>().playSoundAnchor();
        }
        else if (collision.transform.tag == "Target")
        {
            gameScript.score += targetScore;
            collision.gameObject.GetComponent<Target>().Drop();    
        }
        else if (collision.transform.tag == "Point Circle") {
            gameScript.score += pointCircleScore;
        }
        
    }

    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Point Circle")) {
            var PointCircle = other.GetComponent<PointCircle>();
            PointCircle.Hit();
        }
        
    }

    public void checkReadyToLaunch()
    {
        if (transform.position.x < x_limit)
            gameScript.enableBlockingWall();

        if (transform.position.x > x_limit2 && transform.position.z < z_limit)
            gameScript.disableBlockingWall();

        if (Vector3.Distance(transform.position, inCannon.position) < distanceToLaunch)
        {
            gameScript.resetBallTimer();
            gameScript.readyToLaunch = true;
            cannonFlame.Play();
            cannonFlame.gameObject.SetActive(true);
        }
        else
        {
            if (gameScript.readyToLaunch)
                gameScript.startBallTimer();

            gameScript.readyToLaunch = false;
            cannonFlame.Pause();
            cannonFlame.gameObject.SetActive(false);
            
        }

    }

}
