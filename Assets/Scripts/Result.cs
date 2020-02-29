using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    private ToScene toScene;

    private void Start()
    {
        toScene = GetComponent<ToScene>();   
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            toScene.Translate();
        }
    }
}
