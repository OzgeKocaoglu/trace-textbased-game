

class Quest
{
    private string name;
    private string desc;

    private enum QUEST_STATUS
    {
        FINISHED,
        STARTED,
        UNFINISHED,
        UNSTARTED
    }

    private QUEST_STATUS defaultQuestStatus = QUEST_STATUS.UNSTARTED;


}
