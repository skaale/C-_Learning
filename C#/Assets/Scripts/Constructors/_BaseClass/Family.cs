using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{

	public Person father;
	public Person mother;
	public Person son;

	void Start()
	{

		father = new Person();
		father.firstname = "Ole";
		father.lastname = "Vendel";
		father.age = 89;
		father.isMale = true;
		father.isMarried = true;


		mother = new Person();
		mother.firstname = "Alice";

















		Debug.Log(father.firstname + " og " );



	}


}
