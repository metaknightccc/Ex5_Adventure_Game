
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{
    Camera mainCam;
    public GameObject bulletPrefab;
    int bulletForce = 900;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(1)) {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)) {
                transform.LookAt(hit.point);
                GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
            }
        }
    }
}