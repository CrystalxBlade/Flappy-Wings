using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource SFX_Source;
    public AudioClip flap, hit, point;

    public void Play_Flap()
    {
        SFX_Source.PlayOneShot(flap);
    }

    public void Play_Hit()
    {
        SFX_Source.PlayOneShot(hit);
    }

    public void Play_Point()
    {
        SFX_Source.PlayOneShot(point, 0.3f);
    }
}
