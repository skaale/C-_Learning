using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour 
{

	public int a = 5;
	public int b = 5;

	public int totalSum;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update()
	{

		if(Input.GetKeyDown(KeyCode.Space))
		{
			totalSum = Multiply(a,b);
			Debug.Log("Total:" + totalSum );

		}

	}

	public int Multiply(int a, int b ) 
	{

		return a * b;


	}




}
