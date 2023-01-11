using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool loadNextQuesiton = true;
    public bool isAnsweringQuesiton = false;
    public float fillFraction;
    float timerValue = 0;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuesiton)
        {
            if (timerValue <= 0)
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuesiton = false;
            }
            else
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }

        }
        else
        {
            if (timerValue <= 0)
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuesiton = true;
                loadNextQuesiton = true; 
            }
            else
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }

        }
        
        Debug.Log(isAnsweringQuesiton + ": " + timerValue + " = " + fillFraction);
    }
}
