using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraderNPC : MonoBehaviour
{
    public GameObject TradedObject;
    //public Transform TraderDude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Box")
        {
            Instantiate(TradedObject, collision.gameObject.transform.position, collision.gameObject.transform.rotation, collision.gameObject.GetComponentInParent<Transform>());
            Destroy(collision.gameObject);
            // Destroys the object it collides with
        }

    }

}
