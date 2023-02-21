namespace gamedemo;

public class CountedItemList
{
    public List<CountedItem> TheCountedItemList { get; set; }
    
    public void AddCountedItem(CountedItem item)
    {
        TheCountedItemList.Add(item);
    }
    
    public void AddItem(Item item)
    {
        TheCountedItemList.Add(new CountedItem(item, 1));
    }
}