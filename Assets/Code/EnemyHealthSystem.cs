using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    [SerializeField] private int life;
    private bool isDead;

    private void Update()
    {
        if (isDead == true)
        {
            Destroy(this);
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
