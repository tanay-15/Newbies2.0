using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;
    bool dirVertical;
    bool dirHorizontal;
    
    Rigidbody2D playerBody;
    Animator playerAnimation;
	// Use this for initialization
	void Start () {
        playerBody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        dirHorizontal = true;
       // playerAnimation.SetFloat("speed", Mathf.Abs(horizontal));
        float vertical = Input.GetAxis("Vertical");
        dirVertical = true;

       if(dirHorizontal)
        {
            playerAnimation.SetFloat("speedx", Mathf.Abs(horizontal));
        }
       if(dirVertical)
        {
            playerAnimation.SetFloat("speedy", Mathf.Abs(vertical));
        }

        dirHorizontal = false;
        dirVertical = false;

        //if (Mathf.Abs(horizontal) > 0.1f)
        //{
        //    playerAnimation.SetFloat("speed", Mathf.Abs(horizontal));
           

        //}
        //else if (Mathf.Abs(vertical) > 0.1f)
        //{
        //    playerAnimation.SetFloat("speed", Mathf.Abs(vertical));
            
        //}

        handleMovement(horizontal,vertical);
       
	}
    void handleMovement(float directionX,float directionY)
    {
        playerBody.velocity = new Vector2(directionX * speed, directionY* speed);
               
    }

}
