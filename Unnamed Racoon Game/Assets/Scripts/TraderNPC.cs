using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraderNPC : MonoBehaviour
{
    [SerializeField] DialogScript dialog;
    public GameObject TradedObject;
    //public Transform TraderDude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Box")
        {
            
            Instantiate(TradedObject, collision.gameObject.transform.position, collision.gameObject.transform.rotation, collision.transform.parent = null);
            Debug.Log("Instantiate test");
            Destroy(collision.gameObject);
            // Destroys the object it collides with
        }

    }

    // the part below is for npc dialog

    public void Interact()
    {
        DialogManager.Instance.showDialog(dialog);
    }
}
