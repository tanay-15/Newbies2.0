using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour {

    // Use this for initialization
    bool picking = false;
    bool picking_key = false;
    int keys = 0;
    bool opening_door = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        PickingUp();
        OpeningDoor();
	}

    public void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "PickUp")
        {
           
            picking = true;
           
        }

        if(collider.gameObject.tag == "Key")
        {
            picking_key = true;
           
        }

        if(collider.gameObject.tag == "Door")
        {
            opening_door = true;
        }
    }

    void PickingUp()
    {
        if (Input.GetMouseButtonDown(0) && (picking == true))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider != null)
            {
                //object gets destroyed
                //set up a variable before destroying for player inventory system
                Destroy(hit.collider.gameObject);
                picking = false;
            }
        }

        if (Input.GetMouseButtonDown(0) && (picking_key == true))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider != null)
            {
                //object gets destroyed
                //set up a variable before destroying for player inventory system
                Destroy(hit.collider.gameObject);
                picking_key = false;
                keys += 1;
                Debug.Log(keys);
            }
        }
    }

    void OpeningDoor()
    {
        if (Input.GetMouseButtonDown(0) && (opening_door == true) && (keys>0))
        {

            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
                opening_door = false;
                keys -= 1;
                if (keys < 0)
                {
                    keys = 0;
                }
            }
        }
    }


}
