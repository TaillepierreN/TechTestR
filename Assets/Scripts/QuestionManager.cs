using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] Toggle FirstAnswerToQuestion1;
    [SerializeField] Toggle FirstAnswerToQuestion2;
    [SerializeField] TMP_InputField commentaryQuestion3;
    [SerializeField] TMP_Text answer1;
    [SerializeField] TMP_Text answer2;
    [SerializeField] TMP_Text answer3;
    [SerializeField] GameObject surveyPanel;
    [SerializeField] GameObject sentPanel;
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
    public void SendSurvey()
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
        commentary = commentaryQuestion3.text;
        surveyPanel.SetActive(false);
        sentPanel.SetActive(true);
        answer1.text = firstAnswer;
        answer2.text = secondAnswer;
        answer3.text = commentary;

    }
}
