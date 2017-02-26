using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid_ADDExplosionButton : MonoBehaviour 
{
    public Button PressHere;
    public GameObject Cube;
    
    public int xNumObject = 1;
    public int yNumObject = 1;
    public int zNumObject = 1;

    public Vector3 Spacing = Vector3.one;
    public Rigidbody rigbody;
    public float force = 100f;
    public float radius = 5f;
    public float upRadius = 5f;
    public ForceMode forceMode;


    public bool Exp = false;

    public void Start()
    {
        
        Build(Cube);

    }

    public void Build(GameObject Cube)
    {

        for (int x = 0; x < xNumObject; x++)
        {
            for (int y = 0; y < yNumObject; y++)
            {
                for (int z = 0; z < zNumObject; z++)
                {

                    Instantiate(Cube, transform.position + transform.right * x * Spacing.x + transform.position + transform.up * y * Spacing.y + transform.position + transform.forward * z * Spacing.z, Quaternion.identity);
                 
                }

            }

        }
    }

            public void PressHereButton(GameObject Cube)
            {

                  Exp = true;
                  Vector3 explosionPos = transform.position;
                  foreach (Collider col in Physics.OverlapSphere(transform.position, radius))
                        {
                            Rigidbody rb = col.GetComponent<Rigidbody>();

                            if (col.GetComponent<Rigidbody>() != null)
                            {
                                rb.useGravity = true;
                                rb.AddExplosionForce(force, explosionPos, radius, upRadius, forceMode);
                               
                            }
                        

                        }

              }


            
        }



