using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTQuest
{
    private CTQuestStatus status;
    private bool assigned;

    public void Assign()
    {
        assigned = true;
        status = CTQuestStatus.InProgress;
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
