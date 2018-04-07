using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

    // Use this for initialization
    public string NextLevel;
    public Button button;
    void Start () {

        button = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {

        button.onClick.AddListener(ChangeLevel) ;
	}

    void ChangeLevel()
    {
      
        SceneManager.LoadScene(NextLevel);
    }
}
