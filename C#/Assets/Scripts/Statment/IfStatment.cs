using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatment : MonoBehaviour 
{

	public bool WillItBeRainingToday = false;

	// Use this for initialization
	void Start () 
    {
       	/*
		// True If statement
        if(WillItBeRainingToday)
        {
            Debug.Log("Yes you need a umbrella");
        }else
        {
            Debug.Log("No, I dont need a umbrella");
        }
		*/

        
		// false If statement NOT Operator
        if (!WillItBeRainingToday)
        {
            Debug.Log("Yes you need a umbrella");
        }
        else
        {

            Debug.Log("No, I dont need a umbrella");
        }

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
