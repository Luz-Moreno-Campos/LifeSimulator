
namespace LifeSimulator.Characters;

using LifeSimulator.Inventory;

public abstract class Sim : ISim
{
    public string Name { get; }

    public int Health { get; protected set; }

    public int Defense { get; protected set; }

    public int Speed { get; protected set; }

    public int Strength { get; protected set; }

    public int Intellect { get; protected set; }

    public int Agility { get; protected set; }

    public InventoryFacade Inventory { get; } = new();

    protected Sim(string name)
    {
        Name = name;
    }

    public abstract string Act();

    public abstract string Speak();

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Defense: {Defense}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intellect: {Intellect}");
        Console.WriteLine($"Agility: {Agility}");
    }

}