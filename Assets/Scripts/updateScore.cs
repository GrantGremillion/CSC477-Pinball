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
        else
            textBox.SetText("Score: " + gameScript.score.ToString());
    }
}
