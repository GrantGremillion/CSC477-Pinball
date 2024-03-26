using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;
    public AudioSource src4;
    public AudioSource src5;
    
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

    public void playSoundFlipperR()
    {
        src4.Play();
    }

    public void playSoundFlipperL()
    {
        src5.Play();
    }
}
