using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
	public int a;
	public int b;
	public int c;


	int average;



	// Use this for initialization
	void Start () 
	{

		if(a > b)
		{

			Debug.Log("a is greater then b");
		}

		if(a >= b)
		{

			Debug.Log("a is greater and equal to b");
		}

		if(a == b)
		{

			Debug.Log("a equal to b");
		}
		if(a - b == 12)
		{

			Debug.Log("a minus b  is equal to b");
		}

		if(a != b)
		{

			Debug.Log("a is NOT equal to b");
		}





		average = (a + b + c) /3;
		Debug.Log(average);




		
	}

}
