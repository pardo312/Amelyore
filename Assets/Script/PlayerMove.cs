using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public CharacterController2D controller;
	
	float horizontalMove = 0f;
	public float runSpeed = 40f;
	private bool jump = false;
	private bool movLeft = false;
	private bool movRight = false;
	public bool fin = false;
	private Touch touch;
	private Vector3 touchPosition ;
	
    void Update()
    {
		
        //----------Joystick movement---------
		//if(joystick.Horizontal >= .2f)
		//{
		//	horizontalMove = runSpeed;
		//}
		//else if(joystick.Horizontal <= -0.2f)
		//{
		//	horizontalMove = -runSpeed;
		//}
		//else
		//{
			//horizontalMove = 0f;
		//}
		
		//--------Button Movement---------
		
		if(movLeft){
			horizontalMove = -runSpeed;	
		}
		else if(movRight){
			horizontalMove = runSpeed;		
		}
		else{		
			horizontalMove = 0f;
		}
		
		
    }
	
	public void jumpChange(){
		
		jump = true;
	}
	public void  moveRight(){		
		this.movRight = true;
	}
	public void  moveLeft(){
		this.movLeft = true;
	}
	public void  stopRight(){		
		this.movRight = false;
	}
	public void  stopLeft(){
		this.movLeft = false;
	}
	
	
	void FixedUpdate()
    {
		if(fin == false)
		{
		   controller.Move(horizontalMove * Time.fixedDeltaTime, false , jump);
		  
		   jump = false;
		}
		else
		{
			controller.Move(0, false , true);
		}
    }

}
