using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LearningGame : MonoBehaviour
{
    float gameTime;
    public Timer timer;
    public Dictionary<string, string> questions_answers;
    public Button[] answers; //0-3, 0 is top left, 1 top right,
                             //2 bottom left, 3 bottom right
    public ProgressBar progressBar;
    public TMP_Text question;
    int questionPos;
    

    // Start is called before the first frame update
    void Start()
    {
        questions_answers = new Dictionary<string, string>()
        {
            {"What layer is 1.400 miles thick?", "Outer Core" },
            {"What layer is 9,000� F?" , "Outer Core"},
            {"What layer is 9,800� F?" ,"Inner Core"},
            {"Which layer is sandwhiched between the crust and outer core?", "Mantle"},
            {"Which layer is the thickest?","Mantle"},
            {"What layer goes about 19 miles deep on average?","Crust"},
            {"What layer has the consistency of caramel?","Mantle"}
        };

        questionPos = 0;
        question.text = questions_answers.ElementAt(questionPos).Key;



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
            //wait and listen to buttons.
            // if the person gets it correct, pause/reset the timer
            // if incorrect show the correct answer and allow them to move on.

            foreach (Button b in answers)
            {
                int correct = Random.Range(0, answers.Length);
                answers[correct].transform.GetComponentInChildren<TextMeshProUGUI>().text = questions_answers.ElementAt(questionPos).Value;


            }

        }

        //randomly assign answers to the buttons
    }
    

    //Button functionality

    void Next(){
        questionPos = questionPos + 1;
        question.text = questions_answers.ElementAt(questionPos).Key;
    }
}
