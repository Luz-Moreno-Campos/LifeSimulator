using LifeSimulator.Sims;
using LifeSimulator.Inventory;

namespace LifeSimulator.Decorators;

public abstract class SimDecorator : ISim
{
    protected readonly ISim _sim;
  

    public virtual string Name { get { return _sim.Name; } }

    public virtual string SimType { get { return _sim.SimType; }}

    public virtual string Specialization{ get { return _sim.Specialization; }}

    public virtual int Health { get { return _sim.Health; } }

    public virtual int Defense { get { return _sim.Defense; } }

    public virtual int Speed { get { return _sim.Speed; } }

    public virtual int Strength { get { return _sim.Strength; } }

    public virtual int Intellect { get { return _sim.Intellect; } }

    public virtual int Agility { get { return _sim.Agility; } }

    public virtual InventoryFacade Inventory{get { return _sim.Inventory; }}

    protected SimDecorator(ISim sim)
    {
        _sim = sim;
    }


    public virtual string Act()
    {
        return _sim.Act();
    }

    public virtual string Speak()
    {
        return _sim.Speak();
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine("Sim Details:");
        Console.WriteLine();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Character: {SimType}");
        Console.WriteLine($"Specialization: {Specialization}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Defense: {Defense}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intellect: {Intellect}");
        Console.WriteLine($"Agility: {Agility}");
        Console.WriteLine("Items:");

        Inventory.DisplayItems();
    }
}
