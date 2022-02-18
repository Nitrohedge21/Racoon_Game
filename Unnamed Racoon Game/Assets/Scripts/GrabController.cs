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

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(GrabDetect.position, Vector2.right * transform.localScale, rayDist);

        if (grabCheck.collider != null && grabCheck.collider.tag == "Box")
        {
            if (Input.GetKey(KeyCode.G))
            {
                // This part is to grab the box/object
                grabCheck.collider.gameObject.transform.parent = BoxHolder;
                grabCheck.collider.gameObject.transform.position = BoxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                Debug.Log("Item grabbed");
            }
            else
            {
                // This part is to drop the box/object
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                //Might change .isKinematic to gravityscale = 0f because apparently is causes some glitches.
                Debug.Log("Item dropped");
            }
        }
            
            //This part is for the second hand to grab and drop
            RaycastHit2D grabCheck2 = Physics2D.Raycast(GrabDetect2.position, Vector2.left * transform.localScale, rayDist);

            if (grabCheck2.collider != null && grabCheck2.collider.tag == "Box")
            {
                if (Input.GetKey(KeyCode.G))
                {
                    // This part is to grab the box/object
                    grabCheck2.collider.gameObject.transform.parent = BoxHolder2;
                    grabCheck2.collider.gameObject.transform.position = BoxHolder2.position;
                    grabCheck2.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                    Debug.Log("Item grabbed");
                }
                else
                {
                    // This part is to drop the box/object
                    grabCheck2.collider.gameObject.transform.parent = null;
                    grabCheck2.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                    Debug.Log("Item dropped");
                }
            }
        }
    }

