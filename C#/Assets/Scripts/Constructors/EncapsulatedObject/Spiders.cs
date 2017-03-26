using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiders : MonoBehaviour 
{

	public Species maleSpecies;
	public Species femaleSpecies;

	void Start()
	{

		maleSpecies = new Species();
		maleSpecies.speciesName = "Cross spider";
		maleSpecies.sepciesType = "DesertSpider";

		femaleSpecies = new Species();
		femaleSpecies.speciesName = " grass spiders";
		femaleSpecies.sepciesType = "DesertSpider";


		maleSpecies._species = femaleSpecies;
		femaleSpecies._species = maleSpecies;


		if(maleSpecies.GetSpeciesGender(femaleSpecies))
		{
			Debug.Log(maleSpecies.speciesName + " Can evolve with " + femaleSpecies.speciesName );
		}else
			{

			Debug.Log(maleSpecies.speciesName + " and " + femaleSpecies.speciesName + "Cant evolve togther" );

			}

		}

		
	}





