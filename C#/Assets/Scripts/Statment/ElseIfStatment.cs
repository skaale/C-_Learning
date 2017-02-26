using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseIfStatment : MonoBehaviour 
{
    
    
    public int speedLimit = 60;

    
    // Use this for initialization
	void Start () 
    {

       
        Speed();
        
		
	}
	

    public void Speed()
    {

        
        //Check if value is is exactly == 70, is false, so line 12 won’t be executed.
        if (speedLimit == 70)
        {
            Debug.Log("I can drive at maximum speed");
        }
        else if(speedLimit < 70 && speedLimit >= 30)
        {
            Debug.Log("Speed Limit is less than 70 and more equals to 30");
        }
        else if (speedLimit < 30)
        {
            Debug.Log("I better be driving slowly,  30 mph or less");
        }

    }


  
	
}
