using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float AttackType = 1;
    private GameObject player;
    private UnityEngine.AI.NavMeshAgent _agent;
    public float speed = 20.0f;

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
            Vector3 direction = (transform.position - other.transform.position).normalized;
            gameObject.GetComponent<Rigidbody>().AddForce (direction * speed);
            Destroy(other.gameObject);
        }
    }
}
