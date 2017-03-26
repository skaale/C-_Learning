using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{

    public float Richter = 10.0f;

	// Use this for initialization
	void Start () 
    
    {
        if (Richter >= 5 && Richter < 7.0)
        {
            Debug.Log("Wow ! this is more than 5 on Richter  but less then 7 and now it is getting seriously!");

        }else if (Richter >= 7.0 && Richter <= 9.0)
        {
            Debug.Log("Holly molly! It is between 7 and 9 the Ground is Shaking,, Help!! ");

        }else if (Richter > 9)
        {

            Debug.Log("IT IS GREATER THAN 9!!.... This is the end of the world as we know it !! ");

        }else
        {

            Debug.Log("Did you feel something? ");

        }
		
	}
	
	
}
