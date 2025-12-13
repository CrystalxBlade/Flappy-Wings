using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Sound_SFX;
    public AudioClip flap, hit, point;

    public void Play_Flap()
    {
        Sound_SFX.PlayOneShot(flap);
    }
    public void Play_Hit()
    {
        Sound_SFX.PlayOneShot(hit);
    }
    public void Play_Point()
    {
        Sound_SFX.PlayOneShot(point);
    }
}
