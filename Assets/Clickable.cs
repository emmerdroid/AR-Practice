using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public string NameAndType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked ON");
        Destroy(transform.parent.gameObject);
    }
}
