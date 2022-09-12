using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{


    [SerializeField] Material[] layers;
    [SerializeField] GameObject[] layerObj;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            layerObj[i] = this.transform.GetChild(i).gameObject;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
