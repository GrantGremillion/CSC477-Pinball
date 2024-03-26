using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;
    
    public void playSoundCannon()
    {
        src1.Play();
    }

    public void playSoundAnchor()
    {
        src2.Play();
    }

    public void playSoundCircle()
    {
        src3.Play();
    }
}
