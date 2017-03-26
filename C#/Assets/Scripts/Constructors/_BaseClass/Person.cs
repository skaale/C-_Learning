using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*We wrote a class named Person. Notice that I removed :
MonoBehaviour after the name of the class. The main reason is that we treat the class
Person as a simple container of the data, a C# object of type Person
*/

public class Person 
{

	public string firstname = "";
	public string lastname = "";
	public int age = 0;
	public string address = "";
	public bool isMale = false;
	public bool isMarried = false;


}
