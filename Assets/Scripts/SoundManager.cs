using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource SFX_Source; 
    [SerializeField] AudioClip flap, hit, point;

    public void Flap()
    {
        SFX_Source.PlayOneShot(flap);
    } 
    public void Hit()
    {
        SFX_Source.PlayOneShot(hit);
    } 
    public void Point()
    {
        SFX_Source.PlayOneShot(point);
    } 
}
