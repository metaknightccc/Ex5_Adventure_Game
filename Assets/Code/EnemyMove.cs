using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent _agent;
    private bool paused;
    public Animator animator;
    AudioSource _audioSource;
    public AudioClip scream;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        player=GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(LookForPlayer());
        paused = false;
        _audioSource = GetComponent<AudioSource>();
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
                animator.SetBool ("onHit", true);
                _audioSource.PlayOneShot(scream);
                _agent.ResetPath();
                yield return new WaitForSeconds(1.6f);
                animator.SetBool ("onHit", false);
                paused = false;
            }
            yield return new WaitForSeconds(.5f);
            _agent.SetDestination(player.transform.position);
        }
    }
}
