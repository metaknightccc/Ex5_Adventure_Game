using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTrans;
    Vector3 offSet;
    void Start()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - playerTrans.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTrans.position + offSet;
    }
}
