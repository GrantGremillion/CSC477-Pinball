using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;
    public float launchForce;
    public Transform ballStart;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch()
    {
        rb.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Ball reset.");
        if (other.CompareTag("EndPosition"))
        {
            transform.position = ballStart.transform.position;
            rb.velocity = Vector3.zero;
        }
    }

}
