using BaseKit;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest", menuName = "Quests/New Quest", order =1)]
class Quest: ScriptableObject, IQuest
{
    [SerializeField]
    private string questName;
    [SerializeField]
    private string desc;

    [SerializeField]
    private enum QUEST_STATUS
    {
        FINISHED,
        STARTED,
        UNFINISHED,
        UNSTARTED
    }

    private QUEST_STATUS defaultQuestStatus = QUEST_STATUS.UNSTARTED;

    public virtual void startQuest()
    {
        LogManager.log = "This quest name is: "  + this.questName + "\n" + "This quest desc is: " +  this.desc + "\n";
    }
}
