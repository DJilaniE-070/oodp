namespace gamedemo;

public class Item
{
    int ID;
    string Name;
    string NamePlural;
    
    public Item(int id, string nameSingular, string namePlural)
    {
        this.ID = id;
        this.Name = nameSingular;
        this.NamePlural = namePlural;
    }
    
}