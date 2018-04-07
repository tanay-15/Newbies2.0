using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject apple;
    // Use this for initialization
    void Start()
    {
        apple = GameObject.FindGameObjectWithTag("NPC");
    }

    // Update is called once per frame
    void Update()
    {
        if (apple != null)
        {
            Debug.Log("Character");
        }
    }

}
