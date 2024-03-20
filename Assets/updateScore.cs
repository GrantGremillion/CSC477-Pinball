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
        textBox.SetText("Score: " + gameScript.score.ToString());
    }
}
