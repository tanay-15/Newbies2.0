using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DaysCount : MonoBehaviour {

    // Use this for initialization
    int days ;

    public Text DaysText;
    private int dayct;
    public GameObject player;
    [SerializeField] private ObjectPickup OP;
	void Start () {
        OP = player.GetComponent<ObjectPickup>();

        days = 0;
        DaysText = GetComponent<Text>();
        dayct = PlayerPrefs.GetInt("DAYS", 0);
       
    }
	
	// Update is called once per frame
	void Update () {

      
        if (OP.endFlag)
        {
            dayct += 1;
            if (dayct >= 6)
            {
                dayct = 0;
            }

            OP.endFlag = false;
            SceneManager.LoadScene("Phase1");
        }

        DaysText.text = "Days: "+ dayct.ToString();
        PlayerPrefs.SetInt("DAYS", dayct);
        //PlayerPrefs.Save();
    }

    void SetDayCt(int dayct)
    {
        Debug.Log("Days " + dayct);
        
    }

    
}
