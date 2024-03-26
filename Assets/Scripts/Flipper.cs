using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {


    public Rigidbody rb;
    public float force;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    public void Flip() {
        rb.AddForce(Vector3.forward * force);
        
    }
}
