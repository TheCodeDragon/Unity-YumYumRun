using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseMove : MonoBehaviour {
    //Player control script

    //Public variables
    public float fl_impulseForwardSpeed = 10; //running forward
    public float fl_impulseUpSpeed = 5; //Jumping
    public GameObject GO_Treadmill; //Set this to the treadmillbase!
    //Private variables
    private Rigidbody2D rb_Player;//reference to Rigidbody
    private bool bl_isGrounded = true;
	// Use this for initialization
	void Start () {
        rb_Player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D Coll)
    {
        if(Coll.gameObject == GO_Treadmill)
        {
            bl_isGrounded = true;
        }
    }
    void OnCollisionExit2D()
    {
        if(Random.Range(1, 100) > 1) //1 out of 100 chance of letting you JUMP FOREVER
        {
            bl_isGrounded = false;
        }
        
    }
    //Jump mechanism
    public void ImpulseUp()
    {
        //Step 1: Check that the player is grounded
        if(bl_isGrounded)
        {
            //Step 2: If it is grounded, jump. 
            //Todo: Add force to thing: DONE
            rb_Player.AddForce(Vector2.up * fl_impulseUpSpeed, ForceMode2D.Impulse);
        }
    }
    public void ImpulseForward()
    {
        //Todo: add forward force
        rb_Player.AddRelativeForce(Vector2.right * fl_impulseForwardSpeed, ForceMode2D.Impulse);
    }
    


}
