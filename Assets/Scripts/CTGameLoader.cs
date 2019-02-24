using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTGameLoader : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject sceneManager;

    void Awake()
    {
        if (CTGameManager.instance == null)
            Instantiate(gameManager);

        if (CTSceneManager.instance == null)
            Instantiate(sceneManager);
    }
}
