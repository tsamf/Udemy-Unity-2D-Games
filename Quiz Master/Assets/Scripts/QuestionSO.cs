using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Quiz Question", fileName="New Question")]
public class QuestionSO : ScriptableObject 
{
    [TextArea(2,6)]
    [SerializeField]string question = "Enter new question text here";
    [SerializeField]string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string Question{get{return question;}}
    public int CorrectAnswerIndex{get{return correctAnswerIndex;}}

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}
