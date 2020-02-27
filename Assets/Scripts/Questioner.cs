using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questioner : MonoBehaviour
{
    [SerializeField]
    private Text text = default;
    [SerializeField]
    private Checker checker = default;

    private QuestionGenerator generator = null;

    private void Start()
    {
        Open();
    }

    private void Awake()
    {
        generator = GetComponent<QuestionGenerator>();
    }

    public void Open()
    {
        var q = CreateQuestion();
        string symbol = GetSymbolString(q);
        text.text = $"{q.LeftSide} {symbol} {q.RightSide} = ?";
    }

    private Question CreateQuestion()
    {
        // 問題の生成.
        checker.Question = generator.Generate();

        return checker.Question;
    }

    private string GetSymbolString(Question q)
    {
        switch(q.Symbol)
        {
            case Question.SymbolType.Plus:
                return "+";
            case Question.SymbolType.Minus:
                return "-";
            default:
                return "";
        }
    }
}
