using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public string NameAndType;
    [SerializeField] WhackAMole mainGame;
    // Start is called before the first frame update
    void Start()
    {
        mainGame = FindObjectOfType<WhackAMole>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked ON");
        if (NameAndType == mainGame.questions_answers.ElementAt(mainGame.question_index).Value )
        {
            int index = Random.Range(0, mainGame.questions_answers.Count);
            mainGame.question.text = mainGame.questions_answers.ElementAt(index).Key;
            Destroy(transform.parent.gameObject);
            Debug.Log("CORRECT");

        }
        else 
        {
            Destroy(transform.parent.gameObject);
            Debug.Log("WRONG!"); 
        }
    }

    //IEnumerator 
}
