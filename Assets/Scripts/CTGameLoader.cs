using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTGameLoader : MonoBehaviour
{
    public GameObject gameManager;

    void Awake()
    {
        if (CTGameManager.instance == null)
            Instantiate(gameManager);
    }
}
