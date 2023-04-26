using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    public string NameAndType;
    [SerializeField] private WhackAMole mainGame;
    [SerializeField][Range(0f, 1f)] float lerpTime;
    [SerializeField] Color textColor;
    public Transform spawnLoc;
    public GameObject correctEffect, wrongEffect;

    // Start is called before the first frame update
    private void Start()
    {
        mainGame = FindObjectOfType<WhackAMole>();
        StartCoroutine(GoAway());
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.position = spawnLoc.position;
        this.transform.rotation = spawnLoc.rotation;
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked ON");
        if (NameAndType == mainGame.questions_answers.ElementAt(mainGame.question_index).Value)
        {
            int index = Random.Range(0, mainGame.questions_answers.Count);
            //change color to be yellow then back to normal
            ColorChanger(Color.black, Color.yellow);
            mainGame.question.text = mainGame.questions_answers.ElementAt(index).Key;
            //add to score
            mainGame.scoreNum += 20;
            Destroy(transform.parent.gameObject);
            Debug.Log("CORRECT");
            Instantiate(correctEffect);
        }
        else
        {
            //remove from score
            mainGame.scoreNum -= 15;
            //change text color to be red then back normal
            ColorChanger(Color.black, Color.red);
            Destroy(transform.parent.gameObject);
            Debug.Log("WRONG!");
            Instantiate (wrongEffect);
        }
    }

    //make the clickables last for a few seconds
    private IEnumerator GoAway()
    {
        yield return new WaitForSeconds(3);
        Destroy(transform.parent.gameObject);
    }

    void ColorChanger(Color A, Color B)
    {
        StopAllCoroutines();
        StartCoroutine(SmoothColorChange(mainGame.question, A, B, 3f, 1f));
    }

    IEnumerator SmoothColorChange(Text text, Color A, Color B, float duration, float fadeDuration)
    {
        float elapsedTime=0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t= Mathf.Clamp01(elapsedTime / duration);

            text.color = Color.Lerp(A, B, t);
            yield return null;
        }

        //wait for fadeDuration
        yield return new WaitForSeconds (fadeDuration);
        //return to original color
        elapsedTime = 0f;
        while (elapsedTime < duration) 
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / duration);
            text.color = Color.Lerp(B, A, t);
            yield return null;
        }

        text.color = Color.black;

    }
}