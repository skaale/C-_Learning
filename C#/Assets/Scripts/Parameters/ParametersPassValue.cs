using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersPassValue : MonoBehaviour 
{
	public int myNumber = 10;
	// Use this for initialization
	void Start () 
	{
        MyMethod(myNumber);
	}
	
	// Update is called once per frame
	public void MyMethod (int x) 
	{

	

		Debug.Log("My Value is : "  + x );
		
	}


}
