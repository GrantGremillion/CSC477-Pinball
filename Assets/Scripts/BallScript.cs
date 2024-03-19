using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    public float launchForce;
    public Transform ballStart;
    public Transform ballEnd;
    public GamePlay gameScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, ballEnd.position) < 1.5)
        {
            transform.position = ballStart.transform.position;
            rb.velocity = Vector3.zero;
            gameScript.readyToLaunch = true;
        }
    }

    public void Launch()
    {
        rb.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }

}
