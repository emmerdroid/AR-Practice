using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeTest : MonoBehaviour
{
    MeshRenderer mr;
    float t, timer;
    bool lerping = false;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ColorChange(Color.black, Color.red);
        }
    }

    void ColorChange(Color A, Color B)
    {
        
    }
}
