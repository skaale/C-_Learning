using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyIfStatments : MonoBehaviour 
{

    public bool imLateForAMeeeting = true;
	public bool roadConditionsArePerfect = true;


	public bool imHungry = false;
	public bool areKidsHugry = true;

    
	// Use this for initialization
	void Start () 
    {
        //// AND If statement
        //if (imLateForAMeeeting && roadConditionsArePerfect)
        //{
        //    Debug.Log("I need to drive fast!");
        //}else
        //{

        //    Debug.Log("I just need to take it slow!");

        //}

        // OR If statement
        if (imHungry || areKidsHugry)
        {
            Debug.Log("I should cook some food!");
        }
        else
        {

            Debug.Log("We are not hungry!");
        }
        
        
		
	}
	

}
