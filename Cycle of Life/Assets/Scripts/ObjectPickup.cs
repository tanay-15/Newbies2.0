using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class ObjectPickup : MonoBehaviour {

    // Use this for initialization
    bool picking = false;
    bool picking_key = false;
    int keys = 0;
    bool opening_door = false;
    public Inventory invent;
    public Flowchart flowchart;
    
    private bool picks;
    private bool picking_sand;
    private bool dogNear;
    private bool doggo;
    private bool isdognear;
    private bool bulask;
    private bool bulgive;
    private bool bularea;
    public bool endFlag;
    public string BlockName1;
    public string BlockName2;
    public string BlockName3;
    public Image FoodImage;
    

	void Start () {

        //invent = GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {

        PickingUp();
        OpeningDoor();
        DogHelp();
        BullyFood();

    }


    public void DogHelp()
    {

        if ((dogNear == true))
        {
            flowchart.ExecuteBlock(BlockName2);
            doggo = flowchart.GetBooleanVariable("helped");
        }



        if (Input.GetMouseButtonDown(0) && (isdognear == true))
        {


            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider != null)
            {



                if ((doggo == true) && (isdognear == true))
                {
                    Debug.Log("Dog helped!");
                    FoodImage.enabled = false;
                  //  Destroy(hit.collider.gameObject);
                      isdognear = false;
                }
            }


        }
    }
    void BullyFood()
    {
        if (bulask == true)
        {
            flowchart.ExecuteBlock(BlockName3);
            bulgive = flowchart.GetBooleanVariable("paidBully");
        }


       // if (Input.GetMouseButtonDown(0) && (bularea == true))
       // {


          //  Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          //  RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
          //  if (hit.collider != null)
           // {



                if ((bulgive == true)&&(bularea == true))
                {
                    Debug.Log("Dog helpshjldffed!");
                    FoodImage.enabled = false;
                    //  Destroy(hit.collider.gameObject);
                    bularea = false;
                    endFlag = true;
                }
            //}


      //  }

    }

    public void OnCollisionEnter2D(UnityEngine.Collision2D collider)
    {
        if(collider.gameObject.tag == "PickUp")
        {
          //  flowchart.ExecuteBlock("Sandwich");
            picking_sand = flowchart.GetBooleanVariable("picking");
            picking = true;
            
        }
        if(collider.gameObject.tag == "Dog")
        {
            dogNear = flowchart.GetBooleanVariable("helpDog");
            isdognear = true;
        }

        if (collider.gameObject.tag == "Bully")
        {
            bulask = flowchart.GetBooleanVariable("bullyAsk");
            bularea = true;
        }

        if (collider.gameObject.tag == "Key")
        {
            picking_key = true;
           
        }

        if(collider.gameObject.tag == "Door")
        {
            opening_door = true;
        }

        if(collider.gameObject.tag == "Player")
        {

        }

       
       
    }

  

    void PickingUp()
    {
        if (picking_sand == true)
        {
            flowchart.ExecuteBlock(BlockName1);
            picks = flowchart.GetBooleanVariable("picked");
           // Debug.Log(picks);
        }
        

        if (Input.GetMouseButtonDown(0) && (picking == true))
        {


            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider != null)
            {
                


                if ((picks == true) && (picking == true))
                {
                    invent.AddItem(0);
                    Destroy(hit.collider.gameObject);
                    picking = false;
                }
            }


        }    
                
                    
                

               
           // }
        

     /*   if (Input.GetMouseButtonDown(0) && (picking_key == true))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider != null)
            {
                //object gets destroyed
                //set up a variable before destroying for player inventory system
                Destroy(hit.collider.gameObject);
                invent.AddItem(1);
                picking_key = false;
                keys += 1;
                Debug.Log(keys);
            }
        }*/
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
