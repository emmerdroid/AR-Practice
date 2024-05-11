using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TemperatureAnimation : MonoBehaviour
{
    public float countDuration = 1;
    Text numberText;
    float currentValue = 55.99f, targetValue;
    Coroutine _C2T;

    void Awake()
    {
        numberText = GetComponent<Text>();
    }

    IEnumerator CountTo(float targetValue)
    {
        var rate = Mathf.Abs(targetValue - currentValue) / countDuration;
        while (currentValue != targetValue)
        {
            currentValue = Mathf.MoveTowards(currentValue, targetValue, rate * Time.deltaTime);
            numberText.text = ((float)currentValue).ToString() + "� F";
            yield return null;
        }
    }

    public void SetTarget(float target)
    {
        targetValue = target;
        if (_C2T != null)
            StopCoroutine(_C2T);
        _C2T = StartCoroutine(CountTo(targetValue));
    }
}
