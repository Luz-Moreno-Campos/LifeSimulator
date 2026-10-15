using LifeSimulator.Sims;

namespace LifeSimulator.Decorators;

public class CyclistDecorator : SimDecorator
{


    public override string Specialization
    {
        get { return "Cyclist"; }
    }
    public override int Speed
    {
        get { return _sim.Speed + 15; }
    }

    public override int Agility
    {
        get { return _sim.Agility + 10; }
    }

    public override int Strength
    {
        get { return _sim.Strength + 5; }
    }

    public CyclistDecorator(ISim sim) : base(sim)
    {
    }

    public override string Act()
    {
        return $"{_sim.Act()} Trains on long-distance cycling routes.";
    }

    public override string Speak()
    {
        return $"{_sim.Speak()} Endurance and consistency are key.";
    }
}