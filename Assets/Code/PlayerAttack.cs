
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{
    NavMeshAgent _agent;
    Camera mainCam;
    public GameObject bulletPrefab;
    int bulletForce = 900;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)) {
                _agent.SetDestination(hit.point);
            }
        }
        else if (Input.GetMouseButtonDown(1)) {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)) {
                transform.LookAt(hit.point);
                GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
            }
        }
    }
}