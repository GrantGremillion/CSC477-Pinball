
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
    public GameObject canvas;
    public int scorePerTick = 100;
    public bool gameHasStarted = false;
    public Camera cam;

    private float timeOfLaunch;
    private float tickTime = 1f;
    private float timeOnBoard;
    private float timeOfLastTick;
    private int numOfTicksEarned = 0;

    void Start () {
        input = new PinballInput();
        input.Enable();
        canvas.SetActive(true);
    }

    void Update()
    {
        handleKeyPresses();

        handleScore();

        if (Input.GetMouseButton(1)) // Right Click is pressed
            teleportBall();
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    void handleKeyPresses()
    {
        if (gameHasStarted)
        {
            //////////////////////////////////////////////////  KEY  PRESSES  ////////////////////////////////////////////////////

            if (input.Default.FlipperLeftClick.WasPressedThisFrame())
                flipperLeft.Flip();

            if (input.Default.FlipperRightClick.WasPressedThisFrame())
                flipperRight.Flip();

            if (input.Default.Launch.WasPressedThisFrame() && readyToLaunch) {
                ball.Launch();
                timeOfLaunch = Time.time;
                timeOfLastTick = Time.time;
            }

            if (Input.GetKeyDown(KeyCode.R))
                ResetAll();

            if (Input.GetKeyDown(KeyCode.Escape))
                UnityEditor.EditorApplication.isPlaying = false;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }

    void handleScore()
    {
        if (!readyToLaunch)
        {
            timeOnBoard = Time.time - timeOfLaunch;
            if (Time.time - timeOfLastTick > tickTime)
            {
                timeOfLastTick = Time.time;
                score += scorePerTick;
                numOfTicksEarned++;

                if (numOfTicksEarned % 5 == 0)
                    scorePerTick *= 2;
            }
        }
    }

    void teleportBall()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue))
        {
            Vector3 intersectionPoint = raycastHit.point;
            if (intersectionPoint.y > 0.25f && intersectionPoint.y < 0.75f && raycastHit.transform.tag == "Board")
            {
                intersectionPoint.y = 0.8f;
                ball.transform.position = intersectionPoint;
                ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
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
