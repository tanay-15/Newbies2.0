using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;



public class Phase1Trigger1 : MonoBehaviour{

    public Flowchart flowchart;
    public string BlockName;

    
    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            flowchart.ExecuteBlock(BlockName);
        }
    }


    
	
}
