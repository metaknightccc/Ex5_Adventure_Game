using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour
{
    public string levelName = "Scene2";
    public float keyMax = 4.0f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            if (Globals.pickups == keyMax) {
                Debug.Log("Access Granted");
                Globals.pickups = 0;
                Globals.bulletCount = 1;
                SceneManager.LoadScene(levelName);
            }
            
        }
    }

    void Start() {
        Globals.pickups = 0;
    }
}