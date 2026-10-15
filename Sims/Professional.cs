
namespace LifeSimulator.Sims;

public class Professional : Sim
{

    public override string SimType { get { return "Student"; } }
    public Professional(string name) : base(name)
    {
        Health = 70;
        Defense = 80;
        Speed = 50;
        Strength = 65;
        Intellect = 90;
        Agility = 70;
    }

    public override string Act()
    {
        return "Works on new projects.";
    }

    public override string Speak()
    {
        return "Let's stay productive.";
    }
}