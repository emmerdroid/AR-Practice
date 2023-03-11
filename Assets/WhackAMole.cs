using System.Collections;
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
    public GameObject[] moles;
    [SerializeField] private bool gameRunning;

    //public Text timeText;

    public Slider timeSlide;

    private void Start()
    {
        answer_postions = GetComponentsInChildren<Transform>();
        timeRemaining = gameTime;
        timeSlide.maxValue = gameTime;
        gameRunning = true;
        SliderUpdate();
        StartCoroutine(Spawn());
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
            GameObject correct = Instantiate(moles, answer_postions[index].position, Quaternion.identity);

            if (moles.CompareTag("Correct"))
            {
                Debug.Log("This is the correct answer");
            }
            else
            {
                Debug.Log("Wrong");
            }
        }
    }
}