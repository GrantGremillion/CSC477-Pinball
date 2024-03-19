using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public BallScript ball;
    public Flipper flipperLeft;
    public Flipper flipperRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ball.Launch();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            
            flipperLeft.Flip();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            flipperRight.Flip();
        }
    }
}
