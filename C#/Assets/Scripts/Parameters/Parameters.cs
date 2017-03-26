using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters : MonoBehaviour
{
	
    void Update()
    {
     
		if(Input.GetKeyDown(KeyCode.Space))
		{
			
			TellMeThePosition(gameObject, "Her er jeg DU! Har fundet mig");
			
		}

    }


	//GameObject is a class, gameObject is a variable (which refers to the specific GameObject that the script is attached to).
	//string message
	void TellMeThePosition(GameObject cube, string message)
	{

		Debug.Log("Here is my position:" + cube.transform.position + message);

	}

}
