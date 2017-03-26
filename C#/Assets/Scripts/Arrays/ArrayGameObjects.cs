using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayGameObjects : MonoBehaviour 
{


	public GameObject[] enemies;



	public void Start()
	{
		foreach (GameObject enemy in enemies)

		{
			//enemy.SetActive(false);
			enemy.SetActive(false);
		}


	}

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "MainCamera")
		{
			
		foreach (GameObject enemy in enemies)

			{
			enemy.SetActive(true);

			}

		}

		Debug.Log("All Enemies are visble ATTACK!!!");

	}
}
