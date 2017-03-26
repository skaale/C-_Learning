using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour 
{
	public int[] numbers = {5,6,7,8,9,10};

	void Start()
	{

		foreach(int number in numbers)
		{

		 Debug.Log(number);

		}

	}

}
