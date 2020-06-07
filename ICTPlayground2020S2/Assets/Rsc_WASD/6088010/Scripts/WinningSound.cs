using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningSound : MonoBehaviour
{
    public AudioSource winSound;
    void OnTriggerEnter(Collider other)
    {
        winSound.Play();

    }
}
