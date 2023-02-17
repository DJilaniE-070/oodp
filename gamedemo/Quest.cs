public class Quest
{
    public int Id;
    public string Name;
    public string Description;
    public int RewardExperiencePoints;
    public string RewardGold;
    public string RewardItem;
    public string RewardWeapon;

    public Quest(int id, string name, string description, int rewardExperiencePoints, string rewardGold, string rewardItem, string rewardWeapon, string QuestCompletionItem)
    {
        Id = id;
        Name = name;
        Description = description;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        RewardItem = rewardItem;
        RewardWeapon = rewardWeapon;
    }
}