using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class

[System.Serializable]
public class Item
{
	public int itemID;
	public string itemName;
	public string itemDescription;


	// MyContructer
	public Item(int id, string name, string description)
	{
		itemID = id;
		itemName = name;
		itemDescription = description;

	}

	public Item(int id, string name)
	{

		itemID = id;
		itemName = name;

	}

}
