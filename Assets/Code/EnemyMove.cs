using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent _agent;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        player=GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(LookForPlayer());
    }

    IEnumerator LookForPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
            _agent.SetDestination(player.transform.position);
        }
    }
}
