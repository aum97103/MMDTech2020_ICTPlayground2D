using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDamage : MonoBehaviour
{
    public AudioSource DamageSound;
    void OnTriggerEnter(Collider other)
    {
        DamageSound.Play();
        HealthSystem.Health -= 1;

    }
}