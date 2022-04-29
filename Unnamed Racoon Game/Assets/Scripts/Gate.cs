using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject GateObject;
    //public Transform TraderDude;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TradeBox")
        {
            Destroy(collision.otherCollider.gameObject);
            Debug.Log("debug test pls workkkk");

        }
    }
}

