using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfThenStatments : MonoBehaviour 
{

	public int myAge = 39;


	// Use this for initialization
	void Start () 
	{
		GetAge();

		/*
		if(myAge > 18)
		{

			Debug.Log(" I am older than 18");

		}else
		{

			Debug.Log(" You are NOT! older than 18");

		}
		*/

	}



	void GetAge()
	{

		if(myAge >= 18)
		{

			Debug.Log(" I am older than 18");

		}else if(myAge < 5)
		{

			Debug.Log(" You are a Baby!");

		}else
		{

			Debug.Log("Invalid input!");

		}



	}


	
	// Update is called once per frame
	void Update () 
	{


			
		
	}
}
