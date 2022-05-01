using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private GameObject GateObject;
    //I was trying to make it so that you could drag and drop the required object to unlock the game
    //However, I have to scrap it for now to save time. -01.05.2022

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TradeBox")
        {
            Destroy(collision.otherCollider.gameObject);
            Debug.Log("debug test pls workkkk");

        }
    }
}

