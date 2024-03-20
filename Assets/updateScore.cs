using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updateScore : MonoBehaviour
{
    public GamePlay gameScript;
    public TMP_Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.SetText(gameScript.score.ToString());
    }
}
