
using LifeSimulator.Inventory;

namespace LifeSimulator.Characters;

public interface ISim
{
    string Name { get; }
    int Health { get; }
    int Defense { get; }
    int Speed { get; }
    int Strength { get; }
    int Intellect { get; }
    int Agility { get; }

    InventoryFacade Inventory { get; }

    string Act();

    string Speak();

    void PrintDetails();
}