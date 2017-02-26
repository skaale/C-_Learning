using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour 
{

	public int myNumber = 9;
	public string halloText = "Hello World";
	public float commaNumber = 23.72f;
	public bool trueOrFalse = true;
	 

	// Use this for initialization
	public void Start () 
	{	
		//besked til dig 
		// besked til dig
		myNumber = 200;
		Debug.Log("Hej med dig");
		Debug.Log(2+9);
		Debug.Log(11 + myNumber);
		Debug.Log(halloText);
		Debug.Log("My float number" + commaNumber);
		Debug.Log(trueOrFalse);


		Debug.Log(myNumber);
	}


	//Data Types We declare type of variable
	//*---------------------------------------*

	// TekstStreng
	//string text = "Hello World";

	// Heltal
	//int wholeNumber = 42;

	//Kommatal
	//float commaNumber = 23.72f;

	//Sand eller falsk værdi
	//bool trueOrFalse = true;
	//*---------------------------------------*



	

}
