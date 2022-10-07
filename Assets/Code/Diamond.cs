using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            Debug.Log("Got Item");
            Globals.pickups++;
            Globals.bulletCount++;
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);
        }
    }
}