
namespace LifeSimulator.Factories;

using LifeSimulator.Characters;

public class LifeSimFactory : ISimFactory
{
    public ISim CreateSim(string character, string name)
    {
        switch (character.ToLower())
        {
            case "student":
                return new Student(name);

            case "professional":
                return new Professional(name);

            case "athlete":
                return new Athlete(name);

            default:
                throw new ArgumentException("Invalid character.");
        }
    }
}