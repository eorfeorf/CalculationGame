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
    [SerializeField]
    private int NumberOfQuestions = 0;
    [SerializeField]
    private ToScene toScene = default;

    private void Awake()
    {
        checker.OnAfterChecking += OnAfterChecking;
        
    }

    private void OnAfterChecking(bool isCorrect)
    {
        if(isCorrect)
        {
            Correct(respondent.CorrectCount == NumberOfQuestions);
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
            toScene.Translate();
        }
        else
        {
            // TODO:次の問題.
            // 次の問題へ.
            Debug.Log("正解！次！");
            questioner.Open();
        }
    }

    private void Incorrect()
    {
        // TODO:次の問題.
        // 次の問題へ.
        Debug.Log("不正解！次！");
        questioner.Open();
    }
}
