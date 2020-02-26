using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Question
{
    public enum SymbolType
    {
        Plus,
        Minus,
    }

    public int Answer;
    public int LeftSide;
    public int RightSide;
    public SymbolType Symbol;
}
