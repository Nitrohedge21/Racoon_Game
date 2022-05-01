using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject SpawnedObject;
    public bool playerInRange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        
        if (playerInRange == true && Input.GetKeyDown(KeyCode.Z))
        {
            
            Debug.Log("Testing");
            Instantiate(SpawnedObject, gameObject.transform.position, gameObject.transform.rotation, transform.parent = null);
            Debug.Log("Raw Meat spawned in.");
        }
    }
    

    //This script is almost the same one as dialog but i might make some changes so that's why I created a new one
    //instead of re-using that one. -30.04.2022



}
