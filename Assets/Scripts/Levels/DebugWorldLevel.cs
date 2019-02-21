using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugWorldLevel : CTLevel
{
    void Start()
    {
        Init();
        OnEnter();
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered Debug World");
    }
}
