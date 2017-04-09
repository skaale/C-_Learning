using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{ 
	public float jumpForce = 6f;
	public float runningSpeed = 1.5f;
	public float dist = 2.2f;
	public float speed = 1.0f;
	public string axisName = "Horizontal";



	private Rigidbody2D rigidBody;



	void Start() 
	{
		rigidBody = GetComponent<Rigidbody2D>();
	}


	// Update is called once per frame
	void Update () 
	{

	
		if (Input.GetMouseButtonDown(0)) 
		{

			Jump();
		}


		//transform.position += transform.right * Input.GetAxis(axisName)*speed*Time.deltaTime;
		transform.position += transform.right * Input.GetAxis(axisName) * speed * Time.deltaTime ;
	}


	void Jump() 
	{
	if (IsGrounded()) 
		{
			rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}


	public LayerMask groundLayer;
	bool IsGrounded() 
	{
		if (Physics2D.Raycast(this.transform.position, Vector2.down, dist ,groundLayer.value)) 
		{
			return true;
		}
		else {
			return false;
		}
	}
}
