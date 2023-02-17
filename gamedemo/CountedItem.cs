namespace gamedemo;

public class CountedItem
{
    Item TheItem;
    int Quantity;
    
    public CountedItem(Item item, int amount)
    {
        this.TheItem = item;
        this.Quantity = amount;
    }
}