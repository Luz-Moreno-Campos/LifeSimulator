using LifeSimulator.Engine;

namespace LifeSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new();

            controller.RunApp();
        }
    }
}
