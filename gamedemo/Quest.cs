public class Quest
{
    public int ID {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public int RewardExperiencePoints {get; set;}
    public string RewardGold {get; set;}
    public string RewardItem {get; set;}
    public string RewardWeapon {get; set;}

    public Quest(int id, string name, string description, int rewardExperiencePoints, string rewardGold, string rewardItem, string rewardWeapon, string QuestCompletionItem)
    {
        ID = id;
        Name = name;
        Description = description;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        RewardItem = rewardItem;
        RewardWeapon = rewardWeapon;
    }
}