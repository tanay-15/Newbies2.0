using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D player ;
    public GameObject pointB;
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.transform.position = pointB.transform.position;
        }
    }
}
