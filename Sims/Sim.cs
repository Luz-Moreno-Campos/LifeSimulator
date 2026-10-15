
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


}