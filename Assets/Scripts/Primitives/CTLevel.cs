using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTLevel : MonoBehaviour
{
    [SerializeField] private string displayName;
    public int timesEntered;
    public Scene scene;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Loaded Scene: " + scene.name);
        this.scene = scene;
    }

    public virtual void OnEnter()
    {
        timesEntered++;
    }

    public virtual void OnFirstEnter() { }

    public virtual void Init()
    {
        timesEntered = 0;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
