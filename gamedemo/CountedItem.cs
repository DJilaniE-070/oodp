namespace gamedemo;

public class CountedItem
{
    public Item TheItem {get; set;}
    public int Quantity {get; set;}
    
    public CountedItem(Item item, int amount)
    {
        this.TheItem = item;
        this.Quantity = amount;
    }
}