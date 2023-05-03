using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] Toggle FirstAnswerToQuestion1;
    [SerializeField] Toggle FirstAnswerToQuestion2;
    string firstAnswer;
    string secondAnswer;
    string commentary;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SendSurvey()
    {
        if(FirstAnswerToQuestion1.isOn)
        {
            firstAnswer = "Oui";
        }
        else
        {
            firstAnswer = "Non";
        }
                if(FirstAnswerToQuestion2.isOn)
        {
            secondAnswer = "Oui";
        }
        else
        {
            secondAnswer = "Non";
        }
    }
}
