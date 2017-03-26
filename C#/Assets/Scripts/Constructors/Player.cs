using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{

	public Item[] items = new Item[5];

	 
	// Use this for initialization
	void Start () 
	{
		items[0] = new Item(0, "Long Sword", " Very sharp!");
		items[1] = new Item(1, "Longbow"," Very precise!");


	}
	

}
