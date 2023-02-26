using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowAndShrink : MonoBehaviour
{
    //attach to buttons 

    //in update use an if statement check if game object is null if it
    // is use find object of type in order to get the instantiated object
    // if it isn't empty, continue to listen for presses and scale
    // accordingly

    [SerializeField] GameObject Planet;
    public float max;
    public float min;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Planet == null)
        {
           var script = FindObjectOfType<ViewChanger>();
           Planet = script.gameObject;
        }
    }

    public void GrowClick()
    {
        Planet.transform.localScale *= 1.25f;
    }

    public void ShrinkCLick()
    {
        Planet.transform.localScale *= .8f;
    }
}
