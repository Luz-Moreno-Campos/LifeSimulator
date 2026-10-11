
namespace LifeSimulator.Factories;

using LifeSimulator.Characters;

public interface ISimFactory
{
    ISim CreateSim(string character, string name);
}
