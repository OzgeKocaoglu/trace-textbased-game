using BaseKit;
using UnityEngine;

class QuestManager: BaseObject
{
    [SerializeField]
    public Quest[] quests;

    public override void onUpdateBaseObject()
    {
          for (int i = 0; i < quests.Length; i++)
            {
            if (Input.GetKeyDown(KeyCode.A))
            {

                quests[0].startQuest();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                quests[1].startQuest();
            }
        }

       
    }
}
