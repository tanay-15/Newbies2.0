using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;
    bool facingRight;
    Rigidbody2D playerBody;
    Animator playerAnimation;
	// Use this for initialization
	void Start () {
        playerBody = GetComponent<Rigidbody2D>();
        //playerAnimation = GetComponent<Animator>();
        facingRight = true; 
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        //playerAnimation.SetFloat("speed", Mathf.Abs(horizontal));
        float vertical = Input.GetAxis("Vertical");
        handleMovement(horizontal,vertical);
       
	}
    void handleMovement(float directionX,float directionY)
    {
        playerBody.velocity = new Vector2(directionX * speed, directionY* speed);
               
    }

}
