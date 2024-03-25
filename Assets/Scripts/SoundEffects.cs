using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src1;
    public AudioSource src2;
    
    public void playSoundCannon()
    {
        src1.Play();
    }

    public void playSoundAnchor()
    {
        src2.Play();
    }
}
