using LifeSimulator.Sims;

namespace LifeSimulator.Decorators;

public class BusinessDecorator : SimDecorator
{
   

    public override string Specialization
    {
        get { return "Business"; }
    }
    public override int Intellect
    {
        get { return _sim.Intellect + 5; }
    }

    public override int Defense
    {
        get { return _sim.Defense + 10; }
    }

    public BusinessDecorator(ISim sim) : base(sim)
    {
    }
    public override string Act()
    {
        return $"{_sim.Act()} Develops business strategies.";
    }

    public override string Speak()
    {
        return $"{_sim.Speak()} I enjoy analysing markets and opportunities.";
    }
}
