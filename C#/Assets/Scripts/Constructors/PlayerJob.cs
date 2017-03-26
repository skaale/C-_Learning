using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJob : MonoBehaviour 
{
	public Job[] jobs = new Job[5];
	// Use this for initialization
	void Start () 
	{

		jobs[0] = new Job("Software Engineer", "programmer", 100000);
		jobs[1] = new Job("","",0);
	}
	

}
