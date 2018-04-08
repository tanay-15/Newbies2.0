using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {


    public Image[] itemImages = new Image[numOfslots];
    public GameObject[] items = new GameObject[numOfslots];
    public const int numOfslots = 4;
    private Sprite sr;


    public void AddItem(int i)
    {
        
        for(int j = 0;j < numOfslots; j++)
        {
            //items[i] = itemToAdd;
            //itemImages[i].sprite = sr;
            if (j == i)
            {
                itemImages[i].enabled = true;
                return;
            }
            
            
        }
              
            
        
    }

  /*  public void RemoveItem(GameObject itemToRemove) 
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] == itemToRemove)
            {
                items[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }
        }
    }*/
}
