using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jump : MonoBehaviour

{ 

	public float jumpForce = 5f;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{

		rb = GetComponent<Rigidbody2D>();
		
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

		//rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse );
	

	}



}
