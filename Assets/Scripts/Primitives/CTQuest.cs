using UnityEngine;

public class CTQuest : MonoBehaviour
{
    public CTQuestId id;
    public CTQuestStatus status { get; private set; } = CTQuestStatus.Ready;
    public bool assigned { get; private set; } = false;
    [SerializeField] public string title;
    [SerializeField] public string description;
    [SerializeField] public CTQuestStep[] steps;

    public void Assign() => assigned = true;
    public void MarkCompleted() => status = CTQuestStatus.Completed;
    public void MarkFailed() => status = CTQuestStatus.Failed;
}
