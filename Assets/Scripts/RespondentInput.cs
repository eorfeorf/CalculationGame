using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespondentInput : MonoBehaviour
{
    [SerializeField]
    private InputField inputField = default;
    [SerializeField]
    private Checker checker = default;
    
    private void Awake()
    {
        checker.OnCorrect += OnCorrect;
        checker.OnIncorrect += OnIncorrect;
    }

    private void OnCorrect()
    {
        inputField.text = "";
    }

    private void OnIncorrect()
    {
        inputField.text = "";
    }
}
