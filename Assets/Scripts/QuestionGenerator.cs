using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class QuestionGenerator : MonoBehaviour
{
    public Question Generate()
    {
        // 左辺、右辺、記号を設定.
        var ret = new Question()
        {
            LeftSide = Random.Range(0, 10),
            RightSide = Random.Range(0, 10),
            Symbol = (Question.SymbolType)Random.Range(0, 2)
        };

        // 記号を見て答えを設定.
        ret.Answer = CalcAnswer(ret);

        return ret;
    }

    private int CalcAnswer(Question question)
    {
        switch (question.Symbol)
        {
            case Question.SymbolType.Plus:
                return question.LeftSide + question.RightSide;
            case Question.SymbolType.Minus:
                return question.LeftSide - question.RightSide;
            default:
                return 0;
        }
    }
}
