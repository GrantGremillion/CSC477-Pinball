
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    [HideInInspector] public PinballInput input;
    public BallScript ball;
    public Flipper flipperLeft;
    public Flipper flipperRight;
    public bool readyToLaunch = true;
    public int score = 0;
    public int lives = 5;
    public GameObject blockingWall;
    public int scorePerTick = 100;
    public bool gameHasStarted = false;

    private float timeOfLaunch;
    private float tickTime = 1f;
    private float timeOnBoard;
    private float timeOfLastTick;
    private int numOfTicksEarned = 0;

    void Start () {
        input = new PinballInput();
        input.Enable();
    }

    void Update()
    {
        handleKeyPresses();

        if (!readyToLaunch)
        {
            timeOnBoard = Time.time - timeOfLaunch;
            if (Time.time - timeOfLastTick > tickTime)
            {
                timeOfLastTick = Time.time;
                score += scorePerTick;
                numOfTicksEarned++;

                if (numOfTicksEarned % 5 == 0)
                {
                    scorePerTick += 100;
                }
            }
        }

    }

    void handleKeyPresses()
    {
        if (gameHasStarted)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            if (input.Default.FlipperLeftClick.WasPressedThisFrame()) {
                flipperLeft.Flip();
            }
            else if (input.Default.FlipperRightClick.WasPressedThisFrame()) {
                flipperRight.Flip();
            }
            else if (input.Default.Launch.WasReleasedThisFrame() && readyToLaunch) {
                ball.Launch();
                timeOfLaunch = Time.time;
                timeOfLastTick = Time.time;
            }

            if (Input.GetKeyDown(KeyCode.R))
                ResetAll();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }

    public void enableBlockingWall()
    {
        blockingWall.GetComponent<BoxCollider>().enabled = true;
        blockingWall.GetComponent<MeshRenderer>().enabled = true;
    }

    public void disableBlockingWall()
    {
        blockingWall.GetComponent<BoxCollider>().enabled = false;
        blockingWall.GetComponent<MeshRenderer>().enabled = false;
    }

    public void ResetAll()
    {
        ball.ResetBall();
        score = 0;
        lives = 5;
    }
}
