using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    private bool isPick;
    public HealthSystem healthScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            healthScript = GameObject.FindObjectOfType(typeof(HealthSystem)) as HealthSystem;
            isPick = healthScript.Health(1);
        }

        if (isPick)
        {
            Destroy(gameObject);
        }
    }
    
}
