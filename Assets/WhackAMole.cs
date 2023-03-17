using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WhackAMole : MonoBehaviour
{
    /// <summary>
    /// This class will work that it will get the access to the children
    /// to get their postions
    /// the answers will then continuosly be randomized in 2.5 intervals?
    /// only 1 will be correct
    ///
    /// The timer per question should be 10 or 15 seconds? depends on the intervals
    /// </summary>
    // Start is called before the first frame update
    private Transform[] answer_postions;
    public float gameTime;
    private float timeRemaining;
    bool occupied;
    public GameObject[] moles;
    [SerializeField] private bool gameRunning;

    public Dictionary<string, string> questions_answers;

    //public Text timeText;

    public Slider timeSlide;
    public Text question;
    public int question_index;

    private void Start()
    {
        answer_postions = GetComponentsInChildren<Transform>();
        questions_answers = new Dictionary<string, string>()
        {
            {"Pick the Crust", "Crust" },
            {"Pick the Mantle" , "Mantle"},
            {"Pick the Inner Core" ,"Inner Core"},
            {"Pick the Outer Core", "Outer Core"}

        };
        timeRemaining = gameTime;
        timeSlide.maxValue = gameTime;
        gameRunning = true;
        SliderUpdate();
        StartCoroutine(Spawn());
        //Have one of the questions as the text question
        question_index = Random.Range(0, questions_answers.Count);
        question.text = questions_answers.ElementAt(question_index).Key;
    }

    // Update is called once per frame
    private void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            StopAllCoroutines();
            gameRunning = false;
        }
        
        SliderUpdate();
    }

    private void SliderUpdate()
    {
        timeSlide.value = timeRemaining;
    }

    private IEnumerator Spawn()
    {
        while (gameRunning)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 2.5f));
            int index = Random.Range(0, answer_postions.Length);
            int mole_index = Random.Range(0, moles.Length);
            GameObject correct = Instantiate(moles[mole_index], answer_postions[index].position, Quaternion.identity);

            //if (correct.CompareTag("Correct"))
            //{
            //    Debug.Log("This is the correct answer");
            //}
            //else
            //{
            //    Debug.Log("Wrong");
            //}
        }
    }
}