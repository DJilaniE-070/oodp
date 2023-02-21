namespace gamedemo;

public class Weapon
{
    public int ID;
    string name;
    string NamePlural;
    int MinimumDamage;
    int MaximumDamage;
    
    public Weapon(int id, string nameSingular, string namePlural, int minDamage, int maxDamage)
    {
        this.ID = id;
        this.name = nameSingular;
        this.NamePlural = namePlural;
        this.MinimumDamage = minDamage;
        this.MaximumDamage = maxDamage;
    }
}