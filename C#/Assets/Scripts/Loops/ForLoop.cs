using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    public int numEnemies = 3;


    void Start()
    {
        //for loop 
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}
