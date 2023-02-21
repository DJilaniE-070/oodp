using gamedemo;

public class Player
{
    public string Name;
    public int CuHp { get; set; }
    public int MaxHp { get; set; }
    public int Gold { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    public Weapon CurrentWeapon { get; set; }
    public CountedItemList Inventory { get; set; }

    public void AddItemToInventory(CountedItem item)
    {
        foreach (CountedItem ci in Inventory.TheCountedItemList)
        {
            if (ci.TheItem.ID == item.TheItem.ID)
            {
                ci.Quantity += item.Quantity;
                return;
            }
        }

        Inventory.TheCountedItemList.Add(item);
    }
    
    public void RemoveItemFromInventory(CountedItem item)
    {
        foreach (CountedItem ci in Inventory.TheCountedItemList)
        {
            if (ci.TheItem.ID == item.TheItem.ID)
            {
                ci.Quantity -= item.Quantity;
                if (ci.Quantity <= 0)
                {
                    Inventory.TheCountedItemList.Remove(ci);
                }
                return;
            }
        }
    }
}