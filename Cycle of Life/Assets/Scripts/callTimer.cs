using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class callTimer : MonoBehaviour {
    public Rigidbody2D player;
    public GameObject pointB;
    public GameObject pointStop;
    public Text timer;
    public float myTimer;
    public bool startTimer;
    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        testforTimer();
        if (startTimer)
        {
            StartTimer();
            CheckForTimer();
        }

    }
    void testforTimer()
    {
        if(player.transform.position == pointB.transform.position)
        {
            startTimer = true;
           
        }
       
    }



    void StartTimer()
    {
       
        myTimer -= Time.deltaTime;
        timer.text = myTimer.ToString("f0"); //f0 is for the number of decimal places.
    }

    void CheckForTimer()
    {
     
        if(myTimer <= 0)
        {
            startTimer = false;
            SceneManager.LoadScene("GameStart");
        }
    }
}
