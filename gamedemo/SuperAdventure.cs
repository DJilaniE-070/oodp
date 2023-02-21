using System;

public class SuperAdventure
{
    public static Player ThePlayer()
    {
        Player player = new Player();
        player.Name = String.Empty;
        player.CuHp = 10;
        player.MaxHp = 10;
        player.Gold = 0;
        player.Xp = 0;
        player.Level = 1;
        return player;
    }

    public static void CurrentMonster()
    {
        //Monster CurrentMonster = new Monster(Id, Name, PluralName, maxDmg, rewardXp, rewardGold, cuHp, maxHp);
    }
}