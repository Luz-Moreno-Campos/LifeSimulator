
using LifeSimulator.Inventory;

namespace LifeSimulator.Sims;

public abstract class Sim : ISim
{
    public string Name { get; }

    public abstract string SimType { get; }

    public virtual string Specialization{ get { return "None"; }}

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
        Console.WriteLine("Sim Details:");
        Console.WriteLine();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Sim type: {SimType}");
        Console.WriteLine($"Specialization: {Specialization}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Defense: {Defense}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intellect: {Intellect}");
        Console.WriteLine($"Agility: {Agility}");
        Console.WriteLine($"Items:");
        Inventory.DisplayItems();
    }

}