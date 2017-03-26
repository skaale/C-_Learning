using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Species
{

	public string speciesName = "";
	public string sepciesType = "";

	public Species _species;


	public bool GetSpeciesGender(Species otherSpecies)
	{
		if(_species != null)
		{
			if(otherSpecies == _species)
			{

				return true;



			}else
			{

				return false;

			}

			}else
			{


				return false;

			}



		}


	}


