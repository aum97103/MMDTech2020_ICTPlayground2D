using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public AudioSource DamageSound;
    void OnTriggerEnter(Collider other)
    {
        DamageSound.Play();
        HealthSystem.Health -= 100;

    }
}
