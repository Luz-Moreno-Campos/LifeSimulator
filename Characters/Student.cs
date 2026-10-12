
namespace LifeSimulator.Characters;

public class Student : Sim
{
    public Student(string name) : base(name)
    {
        Health = 80;
        Defense = 70;
        Speed = 75;
        Strength = 65;
        Intellect = 80;
        Agility = 70;
    }

    public override string Act()
    {
        return "Studies for exams.";
    }

    public override string Speak()
    {
        return "I study hard to excel in my field.";
    }
}