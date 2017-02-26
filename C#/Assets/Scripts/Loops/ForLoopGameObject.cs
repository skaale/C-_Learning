using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopGameObject : MonoBehaviour 
{

    public int cubesY = 10;
    public GameObject cube;

	//public Vector3 offset = Vector3.one;

	// Use this for initialization
	public void Start () 
    {

		for (int y = 0; y < cubesY; y++)
        { 
			Instantiate(cube, transform.position + transform.forward * y , Quaternion.identity);
        }

       
        
		Debug.Log("Nu har du en række af cubes i Y ");
		
	}
	
	// Update is called once per frame
	void Update () 
    {

       
		
	}
}
