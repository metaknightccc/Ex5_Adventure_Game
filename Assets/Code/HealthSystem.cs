using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int life;
    private bool isDead;

    private void Start()
    {
        life = 100;
    }

    void Update()
    {
        if (isDead == true)
        {
            Debug.Log("Dead");
        }
    }

    public void TakeDamage(int damage)
    {
        if (life >= 1)
        {
            life -= damage;
            if (life < 1)
            {
                isDead = true;
            }
            
        }
    }
}
