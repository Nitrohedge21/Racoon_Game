using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDeleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Box" || collision.tag == "CombinedItem" || collision.tag == "TradeBox")
        {
            Debug.Log("Ceased the existence of the box!!!");
            Destroy(collision.gameObject);
        }
    }
}
