using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Collections;
using UnityEngine.SceneManagement;

public class TestingScript : MonoBehaviour
{
    public Button Button_graph;
    public string City;    
    //public String textValue;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("testingScript started!");
        Button btn = Button_graph.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        //Text_city.text = "Birmingham";
    }

	void TaskOnClick(){
        //Debug.Log ("You have clicked the button!");

        //Text txtCity = Text_city.GetComponent<Text>();
        Debug.Log("Graph Loaded - City Selected: " + City);
        StaticClass.CrossSceneInformation = City;
        SceneManager.LoadScene("graph1");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
