using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTeleporter2 : MonoBehaviour
{
    public Transform Microwave;
    public Transform Microwave2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            collision.transform.position = (Microwave.position + new Vector3(1,0,0));
            
        }

    }
}

//Unused Stuff
//transform.position = new Vector3(Microwave.position.x, Microwave.position.y, Microwave.position.z);