using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayGameObjectDistance : MonoBehaviour 
{
	
	public float distanceToEnemies = 20f;

	public GameObject[] enemies;

	void OnDrawGizmos()
	{
		Gizmos.DrawLine(transform.position , enemies[0].transform.position);

	}

	void FixedUpdate()
	{


		if(Vector3.Distance(enemies[0].transform.position , GetComponent<Camera>().transform.position )  < distanceToEnemies )
		{
			
			foreach(GameObject enemy in enemies)
			{

				enemy.GetComponent<Renderer>().gameObject.SetActive(true);

			}

		}else
		{

			foreach(GameObject enemy in enemies)
			{

				enemy.GetComponent<Renderer>().gameObject.SetActive(false);

			}

		}
			

	}

}