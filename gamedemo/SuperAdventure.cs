using System;

public class SuperAdventure
{
    public static void ThePlayer()
    {
        Player player = new Player();
        player.Name = Console.ReadLine() ?? String.Empty;
        player.CuHp = 10;
        player.MaxHp = 10;
        player.Gold = 0;
        player.Xp = 0;
        player.Level = 1;
    }

    public static void CurrentMonster()
    {
        //Monster CurrentMonster = new Monster(Id, Name, PluralName, maxDmg, rewardXp, rewardGold, cuHp, maxHp);
    }
}