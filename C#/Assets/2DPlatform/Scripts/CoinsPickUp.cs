using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsPickUp : MonoBehaviour
{

	public int CoinsToAdd;
	public AudioSource audiocoins;


	void OnTriggerEnter2D(Collider2D other)
	{

		Destroy(gameObject);
		if (other.GetComponent<PlayerController>() == null)
			return;

		CoinCollector.AddCoins(CoinsToAdd);
		audiocoins.Play();

		if(other.gameObject.name == "Coin")
		{
			Destroy(other.gameObject);
		}



	}




}
