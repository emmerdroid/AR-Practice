using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewChanger : MonoBehaviour
{

    public GameObject OuterView;
    public GameObject InnerView;

    [SerializeField] Button viewButton;
    // Start is called before the first frame update
    void Start()
    {
        viewButton = FindObjectOfType<Button>();
        viewButton.onClick.AddListener(ChangeView);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeView()
    {

        Debug.Log("Swap");
        Debug.Log("Outer view is " + OuterView.activeSelf);
        Debug.Log("Inner view is " + InnerView.activeSelf);
        // when pressed, the 2 views switch options
       
        OuterView.SetActive(!OuterView.activeSelf);
        InnerView.SetActive(!InnerView.activeSelf);


        
    }
}
