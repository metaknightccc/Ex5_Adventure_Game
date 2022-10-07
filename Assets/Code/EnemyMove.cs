using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent _agent;
    private bool paused;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        player=GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(LookForPlayer());
        paused = false;
    }
    public void stopMovement() {
        Debug.Log("activated");
        paused = true;
    }
    IEnumerator LookForPlayer()
    {
        while (true)
        {
            if (paused) {
                _agent.ResetPath();
                yield return new WaitForSeconds(1.0f);
                paused = false;
            }
            yield return new WaitForSeconds(.5f);
            _agent.SetDestination(player.transform.position);
        }
    }
}
