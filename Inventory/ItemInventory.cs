
namespace LifeSimulator.Inventory;

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