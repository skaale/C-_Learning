using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour 
{

	public int myNumber = 9;
	public string halloText = "Hello World";
	public float commaNumber = 23.72f;

	public bool trueOrFalse = true;
	 

	public void Start() 
	{
		
		Debug.Log("Hej med dig");
		Debug.Log(2+9);
		Debug.Log(11 + myNumber);
		Debug.Log(halloText);
		Debug.Log("My float number" + commaNumber);
		Debug.Log(trueOrFalse);


	}

	

}
