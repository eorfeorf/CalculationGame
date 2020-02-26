using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Checker checker = default;
    [SerializeField]
    private Respondent respondent = default;
    [SerializeField]
    private Questioner questioner = default;

    private void Awake()
    {
        checker.OnAfterChecking += OnAfterChecking;
    }

    private void OnAfterChecking(bool isCorrect)
    {
        if(isCorrect)
        {
            Correct(respondent.CorrectCount == questioner.QuestionNum);
        }
        else
        {
            Incorrect();
        }
    }

    private void Correct(bool isEnd)
    {
        if (isEnd)
        {
            // TODO:終了処理.
            // 終了.
            Debug.Log("終わり！");
        }
        else
        {
            // TODO:次の問題.
            // 次の問題へ.
            Debug.Log("次！");
        }
    }

    private void Incorrect()
    {
        // TODO:次の問題.
        // 次の問題へ.
        Debug.Log("次！");
    }
}
