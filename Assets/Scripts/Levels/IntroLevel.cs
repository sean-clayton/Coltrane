using UnityEngine;

public class IntroLevel : CTLevel
{
    void Start()
    {
        Init();
        OnEnter();
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("Entered the Intro level");
    }
}
