using LifeSimulator.Characters;

namespace LifeSimulator.Decorators;

public class DeveloperDecorator : SimDecorator
{
    

    public override string Specialization
    {
        get { return "Developer"; }
    }
    public override int Intellect
    {
        get { return _sim.Intellect + 10; }
    }

    public override int Agility
    {
        get { return _sim.Agility + 5; }
    }

    public override int Speed
    {
        get { return _sim.Speed + 15; }
    }

    public DeveloperDecorator(ISim sim) : base(sim)
    {
    }
    public override string Act()
    {
        return $"{_sim.Act()} Develops software solutions.";
    }

    public override string Speak()
    {
        return $"{_sim.Speak()} I enjoy solving technical problems.";
    }
}