using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasControl : MonoBehaviour {
    
    [SerializeField]
    private CanvasGroup initialCanvas;

    [SerializeField]
    private CanvasGroup ObCanvas;
    bool showObjective = true;

    // Use this for initialization
    void Awake()
    {
        initialCanvas.alpha = 0.8f;
        initialCanvas.interactable = true;
        ObCanvas.alpha = 0.5f;
        ObCanvas.interactable = true;
    }

    void Start () {
        
	}
    void hideCanvas()
    {
        ObCanvas.alpha = 0f;
        ObCanvas.interactable = false;
        ObCanvas.blocksRaycasts = false;
       
    }

    void showCanvas()
    {
        ObCanvas.alpha = 0.5f;
        ObCanvas.interactable = true;
        ObCanvas.blocksRaycasts = true;
       
    }

    public void OnButtonClick()
    {
        if (showObjective == false)
        {
            showObjective = true;
        }
        else if(showObjective == true)
        {
            showObjective = false;
        }
            
    }
	// Update is called once per frame
	void Update () {
        //    if(Input.GetKeyDown(KeyCode.O))
        //       {
        //           showObjective = false;
        //       }
        if (showObjective == false)
        {
            hideCanvas();
        }
        else if (showObjective == true)
        {
            showCanvas();
        }
    }
}
