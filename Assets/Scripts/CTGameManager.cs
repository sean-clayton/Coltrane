using System;
using UnityEngine;

public class CTGameManager : MonoBehaviour
{
    public static CTGameManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        InitGame();
    }

    // Do stuff for initializing the game here!
    private void InitGame()
    {
        Debug.Log("CTGameManager started!");
        CTSceneManager.instance.LoadScene("MainMenu");
    }
}
