using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Portal
{

public class Player : MonoBehaviour 
{

		public float speed = 2.0f;
		public float jumpHeight = 5.0f;
		public float gravity = 30.0f;


		private Vector3 _moveDirection = Vector3.zero;
		private CharacterController _controller;

	// Use this for initialization
	void Start () 
	{

			_controller = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
			CalculateMovement();
	}

	
	void CalculateMovement()
	{

	if(_controller.isGrounded)
	{
	float h = Input.GetAxis("Horizontal");
	float v = Input.GetAxis("Vertical");
						_moveDirection = new Vector3(h,0,v);
						_moveDirection = transform.TransformDirection(_moveDirection);
						_moveDirection *= speed;
						if(Input.GetButton("Jump"))
							_moveDirection.y = jumpHeight;

					}

			_moveDirection.y -= gravity * Time.deltaTime;
			_controller.Move(_moveDirection * Time.deltaTime);




		}
	
	
	
	
	
	}

}