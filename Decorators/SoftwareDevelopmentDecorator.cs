using LifeSimulator.Sims;

namespace LifeSimulator.Decorators;

public class SoftwareDevelopmentDecorator : SimDecorator
{
  

    public override string Specialization
    {
        get { return "Software Development"; }
    }
    public override int Intellect
    {
        get { return _sim.Intellect + 10; }
    }

    public override int Agility
    {
        get { return _sim.Agility + 15; }
    }

    public SoftwareDevelopmentDecorator(ISim sim) : base(sim)
    {
    }

    public override string Act()
    {
        return $"{_sim.Act()} Builds software applications.";
    }

    public override string Speak()
    {
        return $"{_sim.Speak()} I enjoy creating digital solutions.";
    }
}