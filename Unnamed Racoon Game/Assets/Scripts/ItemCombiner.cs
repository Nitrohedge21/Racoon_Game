using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCombiner : MonoBehaviour
{
    public GameObject TradedObject;
    //private GameObject box;
    //private GameObject combined;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box" /*|| collision.gameObject.tag == "CombinedItem"*/)
        {

            Instantiate(TradedObject, collision.gameObject.transform.position, collision.gameObject.transform.rotation, collision.transform.parent = null);
            Debug.Log("debug test pls workkkk");
            Destroy(collision.gameObject);
            Destroy(collision.otherCollider.gameObject);
            // https://www.codegrepper.com/code-examples/csharp/unity+oncollisionenter2d 
            // was thinking about making it destroy the other collider and found this example
            // This is probably gonna be reused for the gate too -29.02.2022
        }
    }
}
