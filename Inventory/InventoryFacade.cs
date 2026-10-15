
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


    /*
       Returning a boolean helps keep inventory implementation details 
       hidden behind the InventoryFacade,which is  the goals of the Facade 
       pattern. The controller only needs to know whether an item exists,
       not the Item object itself.
    */
    public bool HasItem(string itemName)
    {
        return _inventory.FindItem(itemName) != null;
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