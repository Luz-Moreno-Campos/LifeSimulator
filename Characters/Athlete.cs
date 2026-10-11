
namespace LifeSimulator.Characters;

public class Athlete : Sim
{
    public Athlete(string name) : base(name)
    {
        Health = 110;
        Defense = 85;
        Speed = 95;
        Strength = 100;
        Intellect = 60;
        Agility = 95;
    }

    public override string Act()
    {
        return "Trains for triatlon.";
    }

    public override string Speak()
    {
        return "It's time for my workout.";
    }
}