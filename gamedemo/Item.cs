namespace gamedemo;

public class Item
{
    public int ID;
    public string Name;
    public string NamePlural;
    
    public Item(int id, string nameSingular, string namePlural)
    {
        this.ID = id;
        this.Name = nameSingular;
        this.NamePlural = namePlural;
    }
    
}