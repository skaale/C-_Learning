using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters : MonoBehaviour
{
   
    void Update()
    {
     
		if(Input.GetKeyDown(KeyCode.Space))
		{

			TellMeThePosition(gameObject);

		}

    }


	//GameObject is a class, gameObject is a variable (which refers to the specific GameObject that the script is attached to).
	//string message
	void TellMeThePosition(GameObject go)
	{

		Debug.Log("Position:" + go.transform.position);

	}

}
