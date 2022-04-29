 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{

    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                //Makes the dialog box appear, now gonna try to figure out how to make it so that a small bubble appears on the npc's head
                //so that the player can know that they can talk to them. - 17.04.2022
            }
           
        }
        if (!playerInRange)
        {
            dialogBox.SetActive(false);
            //Closes the dialog box if the player leaves the range of npc
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player is in the range of NPC");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player left the range of NPC");
        }
    }
}
