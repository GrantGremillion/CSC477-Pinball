using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {


    public bool triggered = false;
    public Vector3 up;
    public Vector3 down;
    public Vector3 downDist = 1;



    void Start() {
        up = transform.position;
        down = transform.position - downDist

    }

    public void Drop(){
        transform.position = down;
    }

    public void Raise(){
        transform.position = up;

    }
}