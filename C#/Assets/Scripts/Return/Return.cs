using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour 
{

	public int a = 5;
	public int b = 5;

	public int total;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update()
	{

		if(Input.GetKeyDown(KeyCode.Space))
		{
			total = Multiply(a,b);
			Debug.Log("Total:" + total );

		}

	}

	public int Multiply(int a, int b ) 
	{

		return a * b;


	}




}
