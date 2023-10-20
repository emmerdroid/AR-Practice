using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public int  MaxTime;
    public float timer;
    [SerializeField]Image timerBar;
    public bool timerRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = MaxTime;
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning) 
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerBar.fillAmount = timer / MaxTime;
            }
            else
            {
                Debug.Log("Time ran out.");
                timerRunning = false;
            }
        }
        
    }
}
