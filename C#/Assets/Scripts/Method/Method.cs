using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour 
{

    public int number1 = 1;
    public int number2 = 9;

	// Use this for initialization
	void Start () 
 	{
		// this method returns a value
		AddNumber(number1,number2 );
		
	}
	
	// Update is called once per frame
	void Update() 
    {
		
        //if (Input.GetKeyUp(KeyCode.Return))
            //AddNumber();

	}


	public void AddNumber(int x, int y)
    {

        Debug.Log(number1 + number2);
        
    }


}
