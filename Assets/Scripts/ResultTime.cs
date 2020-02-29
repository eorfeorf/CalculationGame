using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTime : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();    
    }

    private void Start()
    {
        float time = Timer.PlayTime;
        text.text = $"{time:f2} sec";
    }
}
