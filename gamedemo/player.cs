using gamedemo;

public class Player
{
    public string Name;
    public int CuHp = 10;
    public int MaxHp = 10;
    public int Gold { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    public int Damage { get; set; }
    public int MaxDamage = 10;
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