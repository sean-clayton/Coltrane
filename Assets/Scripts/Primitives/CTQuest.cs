using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTQuest : MonoBehaviour
{
    public CTQuestId id;
    public CTQuestStatus status { get; private set; } = CTQuestStatus.Ready;
    public bool assigned { get; private set; } = false;
    [SerializeField] public string title;
    [SerializeField] public string description;

    public void Assign() => assigned = true;
    public void MarkFinished() => status = CTQuestStatus.Finished;
    public void MarkFailed() => status = CTQuestStatus.Failed;
}
