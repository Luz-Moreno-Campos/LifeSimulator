
namespace LifeSimulator.Characters;

public class Professional : Sim
{
    public Professional(string name) : base(name)
    {
        Health = 90;
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