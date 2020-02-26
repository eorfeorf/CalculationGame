using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public Question Question { get; set; }
    public Action OnCorrect;
    public Action OnIncorrect;
    public Action<bool> OnAfterChecking;

    public void IsCorrect(string input)
    {
        // 未記入.
        if (input.Equals(""))
            return;

        // 数字じゃない.
        if (!int.TryParse(input, out int inputNumber))
            return;

        // チェック.
        bool IsCorrect = inputNumber == Question.Answer;
        if (IsCorrect)
        {
            // TODO:正解時のリアクション.
            // 正解
            Debug.Log("Correct!");
            OnCorrect.Invoke();
        }
        else
        {
            // TODO:不正解時のリアクション.
            // 不正解
            Debug.Log("Incorrect...");
            OnIncorrect.Invoke();
        }

        OnAfterChecking.Invoke(IsCorrect);
    }
}
