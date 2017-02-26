using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour 
{
	//Array
	public int[] numbers = {0,1,2,3,4,5};
	// Use this for initialization
	void Start () 
	{
		
		foreach(int number in numbers)
		{
			Debug.Log(number);

		}


//		for (int i = 0; i < numbers.Length; i++) 
//		{
//
//			Debug.Log(numbers[i]);
//			
//		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
