
namespace LifeSimulator.Inventory;

public class InventoryFacade
{
    private readonly ItemInventory _inventory = new();

    public void AddItem(string itemName)
    {
        _inventory.AddItem(new Item(itemName));
    }

    public bool RemoveItem(string itemName)
    {
        return _inventory.RemoveItem(itemName);
    }

    public Item? FindItem(string itemName)
    {
        return _inventory.FindItem(itemName);
    }

    public void DisplayItems()
    {
        List<Item> itemsList = _inventory.GetItems();

        if (itemsList.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        foreach (Item item in itemsList)
        {
            Console.WriteLine($"- {item.Name}");
        }
    }
}