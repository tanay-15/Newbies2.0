using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndTIme : MonoBehaviour {

    // Use this for initialization
    //callTimer timer = new callTimer();
    [SerializeField]
    private callTimer timeX;
    public GameObject objecttimer;
    
	void Start () {
      
        timeX = objecttimer.GetComponent<callTimer>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            timeX.startTimer = false;
        }
    }
}
