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
			Debug.Log("I am  driving at maximum speed");	
        }
        else if(speedLimit < 70 && speedLimit >= 30)
        {
            Debug.Log("Speed Limit is less than 70 but faster then 30");
        }
        else if (speedLimit < 30)
        {
            Debug.Log("I am driving slowly,  30 mph or less");
		}else{

			Debug.Log("I am driving TOOO Fast!!");

		}

    }


  
	
}
