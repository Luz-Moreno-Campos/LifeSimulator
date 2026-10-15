using LifeSimulator.Sims;

namespace LifeSimulator.Decorators;

public class ProjectManagerDecorator : SimDecorator
{
   

    public override string Specialization
    {
        get { return "Project Manager"; }
    }

    public override int Intellect
    {
        get { return _sim.Intellect + 5; }
    }

    public override int Defense
    {
        get { return _sim.Defense + 15; }
    }

    public override int Health
    {
        get { return _sim.Defense - 15; }
    }

    public ProjectManagerDecorator(ISim sim) : base(sim)
    {
    }
    public override string Act()
    {
        return $"{_sim.Act()} Coordinates projects and team tasks.";
    }

    public override string Speak()
    {
        return $"{_sim.Speak()} I streamline processes and optimize team workflows.";
    }
}
