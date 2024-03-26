using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetTracker : MonoBehaviour
{
    public GamePlay gameScript;
    public GameObject[] targets;
    bool allDown;
    private int allTargetsBonus = 5000;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("targettracker is running");
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject target in targets)
        {
            Debug.Log(target.transform.name);
        }
        Debug.Log(targets.Length);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        allDown = true;
        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i].GetComponent<Target>().triggered == false)
            {
                allDown = false;
            }
        }
        if (allDown == true)
        {
            // gameScript.score += allTargetsBonus;
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i].GetComponent<Target>().triggered = false;
            }
        }
    }

    public void DownCheck()
    {
        allDown = true;
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Target>().triggered == false)
            {
                allDown = false;
            }
        }
        if (allDown)
        {
            foreach (GameObject target in targets)
            {
                target.GetComponent<Target>().Raise();
                gameScript.score += allTargetsBonus;
            }
        }
    }

    public void RaiseAll()
    {
        Debug.Log("Raising targets");
        Debug.Log("targets length:");
        Debug.Log(targets.Length);
        for (int i = 0; i < targets.Length; i++)
        {
            Debug.Log(targets[i].name);
            targets[i].GetComponent<Target>().triggered = false;
        }
    }
}
