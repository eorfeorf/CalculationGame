using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    private ToScene toScene;
    void Start()
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
