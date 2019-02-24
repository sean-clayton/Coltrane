using UnityEngine;
using UnityEngine.SceneManagement;

public class CTLevel : MonoBehaviour
{
    [SerializeField] public string displayName = "!! DEFAULT DISPLAY NAME !!";
    public int timesEntered = 0;
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

    public virtual void OnLeave() { }

    public void Init() { }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
