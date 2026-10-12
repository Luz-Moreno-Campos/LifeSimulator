using LifeSimulator.Characters;

namespace LifeSimulator.Decorators;

public abstract class SimDecorator : ISim
{
    protected readonly ISim _sim;

    public virtual string Name { get { return _sim.Name; } }

    public virtual int Health { get { return _sim.Health; } }

    public virtual int Defense { get { return _sim.Defense; } }

    public virtual int Speed { get { return _sim.Speed; } }

    public virtual int Strength { get { return _sim.Strength; } }

    public virtual int Intellect { get { return _sim.Intellect; } }

    public virtual int Agility { get { return _sim.Agility; } }


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
        _sim.PrintDetails();
    }
}
