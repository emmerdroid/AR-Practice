using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LearningGame : MonoBehaviour
{
    float gameTime;
    public Timer timer;
    public Dictionary<string, string> questions_answers;
    public Button[] answers; //0-3, 0 is top left, 1 top right,
                             //2 bottom left, 3 bottom right
    public Text question;

    // Start is called before the first frame update
    void Start()
    {
        questions_answers = new Dictionary<string, string>()
        {
            {"What layer is 1.400 miles thick?", "Outer Core" },
            {"What layer is 9,000° F?" , "Outer Core"},
            {"What layer is 9,800° F?" ,"Inner Core"},
            {"Which layer is sandwhiched between the crust and outer core?", "Mantle"},
            {"Which layer is the thickest?","Mantle"},
            {"What layer goes about 19 miles deep on average?","Crust"},
            {"What layer has the consistency of caramel?","Mantle"}
        };

        question.text = questions_answers.ElementAt(0).Key;



    }

    // Update is called once per frame
    void Update()
    {
        //when get a correct answer,
        // pause the timer so the user can choose to progress next.
        //reset the timer for the next question. 

        while (timer.timerRunning) 
        {
            //the game is going

        }

        //randomly assign answers to the buttons
    }
}
