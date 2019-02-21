using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroLevel : CTLevel
{
    void Start()
    {
        base.Init();
        OnEnter();
    }

    public override void OnEnter()
    {
        base.OnEnter();
        if (timesEntered == 1)
        {
            OnFirstEnter();
        }
    }

    public override void OnFirstEnter()
    {
        Debug.Log("Player just started the game. Doing cool intro stuff!");
    }
}
