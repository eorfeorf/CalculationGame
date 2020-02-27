using System;
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
        checker.OnEmpty += OnEmpty;
        checker.OnCorrect += OnCorrect;
        checker.OnIncorrect += OnIncorrect;
    }

    private void Start()
    {
        inputField.ActivateInputField();
    }

    private void OnEmpty()
    {
        inputField.ActivateInputField();
    }

    private void OnCorrect()
    {
        inputField.text = "";
        inputField.ActivateInputField();
    }

    private void OnIncorrect()
    {
        inputField.text = "";
        inputField.ActivateInputField();
    }
}
