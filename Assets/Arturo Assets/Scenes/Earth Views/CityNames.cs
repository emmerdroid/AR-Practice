using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CityNames : MonoBehaviour
{
    public Button Cities;
    public string City;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("City Names script started");
        Button btn = Cities.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Scene 1 - City Selected: " + City);
        StaticClass.CrossSceneInformation = City;
        SceneManager.LoadScene("Placeholder");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
