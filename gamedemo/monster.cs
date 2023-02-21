public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string PluralName { get; set; }
    public int MaxDmg { get; set; }
    public int RewardXp { get; set; }
    public int RewardGold { get; set; }
    public int CuHp { get; set; }
    public int MaxHp { get; set; }

    public Monster(int Id, string name, string pluralName, int maxDmg, int rewardXp, int rewardGold, int cuHp, int maxHp)
    {
        ID = Id;
        Name = name;
        PluralName = pluralName;
        MaxDmg = maxDmg;
        RewardXp = rewardXp;
        RewardGold = rewardGold;
        CuHp = cuHp;
        MaxHp = maxHp;
    }
}