public class QuestList
{
    public List<Quest> QuestLog {get; set;}
    public void addQuest()
    {
        Quest quest = World.QuestByID(1);

        if (true) {
            QuestLog.Add(World.QuestByID(quest.ID));
        };
        
    }
}