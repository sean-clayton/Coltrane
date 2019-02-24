namespace CTQuestSystem
{
    public class CTQuest
    {
        private CTQuestId id;
        private CTQuestStatus status = CTQuestStatus.Ready;
        private bool assigned = false;
        private string title = "!! DEFAULT TITLE !!";
        private string description = "!! DEFAULT DESCRIPTION !!";
        private CTQuestStep[] steps;

        public void Assign() => assigned = true;
        public void MarkCompleted() => status = CTQuestStatus.Completed;
        public void MarkFailed() => status = CTQuestStatus.Failed;
    }
}
