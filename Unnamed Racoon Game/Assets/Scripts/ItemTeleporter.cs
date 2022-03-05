using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTeleporter : MonoBehaviour
{
    public Transform Microwave;
    public Transform Microwave2;

    //Testing the drop with teleporter
    RaycastHit2D grabCheck;
    //If you want to resize an item, make sure that their hitboxes don't get mixed up because that causes the teleporter to glitch out
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            collision.transform.position = (Microwave2.position + new Vector3(1, 0, 0));
            
        }

    }
}

//Unused Stuff
//transform.position = new Vector3(Microwave.position.x, Microwave.position.y, Microwave.position.z);