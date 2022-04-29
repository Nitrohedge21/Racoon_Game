using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform GrabDetect;
    public Transform GrabDetect2;
    public Transform BoxHolder;
    public Transform BoxHolder2;
    public float rayDist;
    private Transform Microwave;
    private Transform Microwave2;

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(GrabDetect.position, Vector2.right * transform.localScale, rayDist);
        // The second part, "or" section, is for the new item that the npc spawns in
        if (grabCheck.collider != null && grabCheck.collider.tag == "Box" || grabCheck.collider != null &&  grabCheck.collider.tag == "TradeBox" || grabCheck.collider != null && grabCheck.collider.tag == "CombinedItem")
        {
            //So i added an input to unity project settings and tried to use that
            //Input.GetButtonDown("Grab") similar to movement inputs but it didn't work out, the player kept dropping the box
            if (Input.GetKey(KeyCode.G))
            {
                // This part is to grab the box/object
                grabCheck.collider.gameObject.transform.parent = BoxHolder;
                grabCheck.collider.gameObject.transform.position = BoxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                //Debug.Log("Item grabbed");
                //Had to comment it out because it kept getting spammed for some reason
                //Might be because there are multiple versions of it?
            }
            else
            {
                // This part is to drop the box/object
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                //Might change .isKinematic to gravityscale = 0f because apparently is causes some glitches.
                //Debug.Log("Item dropped");
                //Check the first grab function to see the reason why it's commented out
            }
        }
            
            //This part is for the second hand to grab and drop
            RaycastHit2D grabCheck2 = Physics2D.Raycast(GrabDetect2.position, Vector2.left * transform.localScale, rayDist);

            if (grabCheck2.collider != null && grabCheck2.collider.tag == "Box" || grabCheck2.collider != null &&  grabCheck2.collider.tag == "TradeBox" || grabCheck2.collider != null && grabCheck2.collider.tag == "CombinedItem")
            {
                if (Input.GetKey(KeyCode.G))
                {
                    // This part is to grab the box/object
                    grabCheck2.collider.gameObject.transform.parent = BoxHolder2;
                    grabCheck2.collider.gameObject.transform.position = BoxHolder2.position;
                    grabCheck2.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                //Debug.Log("Item grabbed");
                //Check the first grab function to see the reason why it's commented out
            }
            else
                {
                    // This part is to drop the box/object
                    grabCheck2.collider.gameObject.transform.parent = null;
                    grabCheck2.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                    //Debug.Log("Item dropped");
                    //Check the first grab function to see the reason why it's commented out
                }
            }
        }
    }

