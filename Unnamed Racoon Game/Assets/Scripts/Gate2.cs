using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(collision.otherCollider.gameObject);
            Debug.Log("debug test pls workkkk");

        }
    }
}
