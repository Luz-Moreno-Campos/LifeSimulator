
namespace LifeSimulator.Engine;

public sealed class SimulationWorld
{
    private static SimulationWorld? _instance;

    private static readonly object _lockObj = new();

    public string NeighbourhoodName { get; }

    public int CurrentDay { get; private set; }

    public string CurrentSeason
    {
        get
        {
            if (CurrentDay >= 1 && CurrentDay <= 30)
            {
                return "Spring";
            }
            else if (CurrentDay >= 31 && CurrentDay <= 60)
            {
                return "Summer";
            }
            else if (CurrentDay >= 61 && CurrentDay <= 90)
            {
                return "Fall";
            }
            else
            {
                return "Winter";
            }
        }
    }

    private SimulationWorld()
    {
        NeighbourhoodName = "River Park South";
        CurrentDay = 1;
    }

    public static SimulationWorld GetInstance()
    {
        if (_instance == null)
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new SimulationWorld();
                }
            }
        }

        return _instance;
    }

    public void AdvanceDay()
    {
        CurrentDay++;
    }
}