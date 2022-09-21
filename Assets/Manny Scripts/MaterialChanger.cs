using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    //Layers ad their element in the object
    /*
     * Element 0 -> Clear Material
     * Element 1 -> Core
     * Element 2 -> Crust 
     * Element 3 -> Crust Out
     * Element 4 -> Inner Core
     * Element 5 -> Mantle
     */

    [SerializeField] Material[] layersMaterials; //materials to use
    [SerializeField] GameObject[] layerObj; // actual layer objects in the prefab
    // Start is called before the first frame update
    void Start()
    {


        for (int i = 0; i < this.transform.childCount; i++)
        {
            layerObj[i] = this.transform.GetChild(i).gameObject;

        }

        for (int i = 0; i < layerObj.Length; i++)
        {
            layerObj[i].gameObject.GetComponent<Renderer>().material = layersMaterials[0];
            //in complete, crust layer has 2 materials so will need to check to see 
            //if this works with that or if needs adjustment

        }
    }

    // Update is called once per frame
    void Update()
    {


        ChangeMaterial();


    }

    //New idea for checking/showing the layers

    /*
     First see if the sphere layer has SetAvtive to false
    If it is false, then show the layer proper
     */
    void ChangeMaterial()
    {
        GameObject[] planets; 
        planets = GameObject.FindGameObjectsWithTag("PlanetLayer");
        for(int i = 0; i <= planets.Length; i++)
        {
            //Check for all these orbs to see that they are active
            //
            if (!planets[i].gameObject.activeSelf)
            {
                //the layer is not active meaning we show it 
                // check the object with the layer name in the array above
                //match the names then change materials

            }
        }

    }




}
