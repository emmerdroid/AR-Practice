using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Description of how code should work
/*
 * Each layer prefab will have a collider
 * The colliders will check to see if they are touching with another prefab that follows along in correct order
 * If so then create a prefab that will have both materials, viewing it in a cross section faction
 *      Will have to make prefab for 2 layer, 3 layer, 4 layer 
 * If not then indicate that the user has done it wrong. 
 * Order of layers will be Outer Crust -> Inner crust -> Mantle -> Core -> Inner Core
 */
public class PlanetLayerDetection : MonoBehaviour
{
    // Start is called before the first frame update
    //get what THIS game object name is/ what layer it is
    //What comes before/after


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "")
        {

        }
    }
}
