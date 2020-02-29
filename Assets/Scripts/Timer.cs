using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
#if false
    private static Timer inst = null;
    public static Timer Inst
    {
        get
        {
            if (Inst != null)
                return inst;

            inst = new Timer();
            return inst;
        }
    }

    private Timer()
    {
    }

    public static void Create()
    {
        inst = new T()
    }

    public static void Destroy()
    {
        inst = null;
    }
#endif

    public static float PlayTime { get; private set; } = 0;

    private bool isActive = false;

    private void Update()
    {
        if (!isActive) return;
        PlayTime += Time.deltaTime;
    }

    public void End()
    {
        isActive = false;
    }

    public void Begin()
    {
        isActive = true;
        PlayTime = 0;
    }
}
