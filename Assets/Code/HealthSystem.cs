using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject[] hearts;
    private int life;
    private bool isDead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (isDead == true)
        {
            Debug.Log("Dead");
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void TakeDamage(int damage)
    {
        if (life >= 1)
        {
            life -= damage;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                isDead = true;
            }
            
        }
    }
}
