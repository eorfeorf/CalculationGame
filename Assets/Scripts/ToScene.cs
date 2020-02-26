using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene : MonoBehaviour
{
    [SerializeField]
    private string sceneName = default;

    public void Translate()
    {
        SceneManager.LoadScene(sceneName);
    }
}
