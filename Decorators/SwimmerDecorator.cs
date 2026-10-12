
using LifeSimulator.Characters;

namespace LifeSimulator.Decorators;

public class SwimmerDecorator : SimDecorator
{
    public SwimmerDecorator(ISim sim) : base(sim)
    {
    }

    public override int Health
    {
        get { return _sim.Health + 10; }
    }

    public override int Strength
    {
        get { return _sim.Strength + 10; }
    }

    public override int Agility
    {
        get { return _sim.Agility + 5; }
    }

    public override string Act()
    {
        return $"{_sim.Act()} Completes intensive swim training sessions.";
    }

    public override string Speak()
    {
        return $"{_sim.Speak()} Technique and discipline drive performance.";
    }
}