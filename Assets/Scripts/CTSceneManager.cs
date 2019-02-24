using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTSceneManager : MonoBehaviour
{
    public static CTSceneManager instance = null;
    AsyncOperation asyncSceneLoader = null;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("Intro");
    }

    public void LoadSceneAsync(string sceneName)
    {
        if (asyncSceneLoader != null)
        {
            Debug.LogWarning("Tried to load scene asynchronously while a scene was already loading!");
            return;
        }
        if (sceneName == null || sceneName == "")
        {
            Debug.LogWarning("Tried to load scene name of null or empty string!");
            return;
        }
        else
        {
            StartLoading(sceneName);
            OnSceneLoaded();
        }
    }

    void StartLoading(string sceneName)
    {
        StartCoroutine(LoadNewSceneAsync(sceneName));
    }

    IEnumerator LoadNewSceneAsync(string sceneName)
    {
        Debug.LogWarning(
                "ASYNC LOAD STARTED" + "\n" +
                "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS!" + "\n" +
                "UNITY WILL CRASH");

        asyncSceneLoader = SceneManager.LoadSceneAsync(sceneName);
        Debug.Log("Started loading scene asynchronously: " + sceneName);
        while (!asyncSceneLoader.isDone)
        {
            float progress = Mathf.Clamp01(asyncSceneLoader.progress / 0.9f);
            Debug.Log(progress * 100f + "%");
            yield return null;
        }
        asyncSceneLoader.allowSceneActivation = true;
        asyncSceneLoader = null;
        OnSceneLoaded();
    }

    private void OnSceneLoaded()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("Done loading scene: " + currentScene.name);
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        Debug.Log("Scene Manager loaded!");
    }

    void OnDisable()
    {
        asyncSceneLoader = null;
    }
}
