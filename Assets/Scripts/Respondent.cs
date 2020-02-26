using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respondent : MonoBehaviour
{
    [SerializeField]
    private Checker checker = default;

    public int CorrectCount => correctCount;
    private int correctCount = 0;

    private void Awake()
    {
        checker.OnCorrect += OnCorrect;
        checker.OnIncorrect += OnIncorrect;
    }

    private void OnCorrect()
    {
        ++correctCount;
    }

    private void OnIncorrect()
    {
    }
}
