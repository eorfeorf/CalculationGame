using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    [SerializeField]
    private AudioClip correctAudioSource;
    [SerializeField]
    private AudioClip incorrectAudioSource;

    public Question Question { get; set; }
    public Action OnEmpty { get; set; }
    public Action OnCorrect { get; set; }
    public Action OnIncorrect { get; set; }
    public Action<bool> OnAfterChecking;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void IsCorrect(string input)
    {
        // 未記入.
        if (string.IsNullOrEmpty(input))
        {
            OnEmpty.Invoke();
            return;
        }

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

            audioSource.clip = correctAudioSource;
        }
        else
        {
            // TODO:不正解時のリアクション.
            // 不正解
            Debug.Log("Incorrect...");
            OnIncorrect.Invoke();

            audioSource.clip = incorrectAudioSource;
        }

        audioSource.Play();

        OnAfterChecking.Invoke(IsCorrect);
    }
}
