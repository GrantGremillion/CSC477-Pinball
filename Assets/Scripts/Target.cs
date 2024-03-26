using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {


    public bool triggered = false;
    public Vector3 up;
    public Vector3 down;

    public float timeSinceDropped;



    void Start() {
        up = transform.position;
        // down = transform.position + (Vector3.down * downDist);
        down = transform.position + new Vector3(0.0f, -0.8f, 0.0f);

    }

    public void Drop(){
        triggered = true;
        transform.position = down;
    }

    public void Raise(){
        transform.position = up;

    }
}