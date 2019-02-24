using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CTUi
{
    public class CTMainMenuNewGameButton : MonoBehaviour
    {
        public void OnClick()
        {
            CTSceneManager.instance.LoadSceneAsync("Intro");
        }
    }
}
