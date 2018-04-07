using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
    public Text timerText;
    public float myTimer = 60;
	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime;
        timerText.text = myTimer.ToString("f0"); //f0 is for the number of decimal places.
        print(myTimer);
	}
 
}
