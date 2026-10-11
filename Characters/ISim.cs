
namespace LifeSimulator.Characters;

public interface ISim
{
    string Act();

    string Speak();

    void PrintDetails();
}