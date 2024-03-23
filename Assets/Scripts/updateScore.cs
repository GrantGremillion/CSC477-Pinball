using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updateScore : MonoBehaviour
{
    public GamePlay gameScript;
    public TMP_Text textBox;

    // Update is called once per frame
    void Update()
    {
        if (transform.tag == "Timer")
            textBox.SetText($"Time: {gameScript.timeOnBoard.ToString()} s");

        else if (transform.tag == "Lives")
            textBox.SetText($"Lives: {gameScript.lives.ToString()}");

        else if (transform.tag == "Score")
            textBox.SetText("Score: " + gameScript.score.ToString());

        else
            textBox.SetText("Final Score: " + gameScript.score.ToString());
    }
}
