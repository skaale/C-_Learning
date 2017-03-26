using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Job
{

	public string jobTitle;
	public string jobDescription;
	public int jobSalary;


	public Job(string title, string descr, int salary)
	{

		jobTitle = title;
		jobDescription = descr;
		jobSalary = salary;

	}


}
