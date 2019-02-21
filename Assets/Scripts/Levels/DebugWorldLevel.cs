using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugWorldLevel : CTLevel
{

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Loaded Scene: " + scene.name);
    }

    void Start()
    {
        timesEntered = 0;
        OnEnter();
    }

    void OnEnter()
    {
        timesEntered++;
        Debug.Log("Entered Debug World");

        if (timesEntered == 1)
        {
            OnFirstEnter();
        }
    }

    void OnFirstEnter()
    {
        Debug.Log("Entered Debug World for the first time");
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
