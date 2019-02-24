using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTQuest
{
    public CTQuestStatus status { get; private set; } = CTQuestStatus.Ready;
    public bool assigned { get; private set; } = false;

    public void Assign()
    {
        assigned = true;
    }

    public void MarkFinished()
    {
        status = CTQuestStatus.Finished;
    }

    public void MarkFailed()
    {
        status = CTQuestStatus.Failed;
    }
}
