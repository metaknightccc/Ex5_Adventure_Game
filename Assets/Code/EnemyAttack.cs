using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float AttackType = 1;
    private GameObject player;
    private UnityEngine.AI.NavMeshAgent _agent;
    public float speed = 300.0f;
 
    public EnemyMove movingTrack;
    public HealthSystem health;

    void Start() {

    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Hit");
        if (other.CompareTag("Player")) {
            health.TakeDamage(1);
            Debug.Log("Damaged");
            //damage player
        }
        else if (other.CompareTag("Bullet")) {
            movingTrack.stopMovement();
            Destroy(other.gameObject);
        }
    }
    /*IEnumerator movement() {
        _agent.speed = 10;
        _agent.angularSpeed = 0;//Keeps the enemy facing forwad rther than spinning
        _agent.acceleration = 20;                    

        yield return new WaitForSeconds(0.2f); //Only knock the enemy back for a short time     

        _agent.speed = 4;
        _agent.angularSpeed = 180;
        _agent.acceleration = 10;
    }*/
}
