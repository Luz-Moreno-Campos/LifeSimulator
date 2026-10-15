
namespace LifeSimulator.Inventory;

/*
 Although this has no practical impact in this project,
 Item and ItemInventory were marked as internal to show how a Facade
 would hide implementation details in a multiple-project application by
 preventing direct access to these classes.
 
*/
internal class ItemInventory
{
    private readonly List<Item> _items = new();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public bool RemoveItem(string itemName)
    {
        Item? item = FindItem(itemName);

        if (item == null)
        {
            return false;
        }

        return _items.Remove(item);
    }

    public Item? FindItem(string itemName)
    {
        return _items.FirstOrDefault( item => item.Name.Equals(itemName,StringComparison.OrdinalIgnoreCase));
    }

    public List<Item> GetItems()
    {
        return _items;
    }
}