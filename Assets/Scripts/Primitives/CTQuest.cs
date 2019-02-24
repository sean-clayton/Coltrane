namespace CTQuestSystem
{
    public class CTQuest
    {
        private CTQuestId id;
        private CTQuestStatus status = CTQuestStatus.Ready;
        private bool assigned = false;
        private string title = "__DEFAULT_TITLE__";
        private string description = "__DEFAULT_DESCRIPTION__";
        private CTQuestStep[] steps;

        public void Assign() => assigned = true;
        public void MarkCompleted() => status = CTQuestStatus.Completed;
        public void MarkFailed() => status = CTQuestStatus.Failed;
    }
}
