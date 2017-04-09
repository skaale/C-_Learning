using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Grounded : MonoBehaviour

{ 

	public float jumpForce = 1f;
	public float dist = 0.5f;



	private Rigidbody2D rigidBody;



	// Use this for initialization
	void Start () 
	{


		rigidBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetMouseButton(0))
		{
		Jump();
		}
		
	}

	void Jump()
	{

		if(IsGrounded())
		{
			rigidBody.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);

		}

		
	}



	public LayerMask groundLayer;

	bool IsGrounded()
	{

		if(Physics2D.Raycast(transform.position, Vector2.down, dist, groundLayer.value))
		{
			return true;


		}else{


			return false;
		}



	}



}
