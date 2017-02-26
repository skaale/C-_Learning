using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour 
{

    public GameObject Cube;
    
    public int xNumObject = 10;
    public int yNumObject = 10;
    public int zNumObject = 10;

    //public Vector3 Spacing = Vector3.one; //* Spacing.x


    public void Start()
    {

     
         
        for (int x = 0; x <  xNumObject; x++)
        {
            for (int y = 0; y < yNumObject; y++)
            {
                for (int z = 0; z < zNumObject; z++)
                {

                    Instantiate(Cube, transform.position + transform.right * x  + transform.position + transform.up * y  + transform.position + transform.forward * z , Quaternion.identity);

                }
                           
            }
               
         }

                
            }

        }



