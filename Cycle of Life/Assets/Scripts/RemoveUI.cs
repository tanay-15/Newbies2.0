using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RemoveUI : MonoBehaviour,IPointerClickHandler {

    // Use this for initialization
    public Image image;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData data)
    {
        RemoveItem();
    }

   public void RemoveItem()
    {

        image.enabled = false;
    }
}
