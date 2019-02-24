using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CTMainMenuButton : MonoBehaviour
{

    Button myButton;
    private TextMeshProUGUI text;
    [SerializeField] public bool isDisabled = true;

    void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        if (!isDisabled)
            text.color = new Color(255, 255, 255, 0.5f);
        else
            text.color = new Color(255, 255, 255, 0.1f);
    }

    public void OnHover()
    {
        if (!isDisabled)
            text.color = new Color(255, 255, 255, 1.0f);
    }

    public void OnUnHover()
    {
        if (!isDisabled)
            text.color = new Color(255, 255, 255, 0.5f);
    }

    public void Disable()
    {
        isDisabled = true;
        text.color = new Color(255, 255, 255, 0.1f);
    }

    public void Enable()
    {
        isDisabled = false;
        text.color = new Color(255, 255, 255, 0.5f);
    }

}
