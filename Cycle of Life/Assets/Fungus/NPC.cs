using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
[EventHandlerInfo("NPCs","Simple NPC","Executes on Collision")]
public class NPC : EventHandler {
    public bool click = false;

	// Use this for initialization
	void Start () {
		
	}
	void Dialogue()
    {
        ExecuteBlock();
    }
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            click = true;
            Dialogue();
        }
        
	}

}
