
namespace LifeSimulator.Factories;

using LifeSimulator.Sims;

public interface ISimFactory
{
    ISim CreateSim(string character, string name);
}
