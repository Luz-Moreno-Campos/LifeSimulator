namespace LifeSimulator.Engine;
using LifeSimulator.Sims;
using LifeSimulator.Decorators;
using LifeSimulator.Factories;
using LifeSimulator.Inventory;

public class GameController
{
    private ISim? _currentSim;

    private readonly ISimFactory _simFactory = new LifeSimFactory();

    private readonly SimulationWorld _world = SimulationWorld.GetInstance();

    public void RunApp()
    {
        bool isRunning = true;

        while (isRunning)
        {
            

            DisplayMenu();

            string? choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    CreateSim();
                    break;

                case "2":
                    AssignSpecialization();
                    break;

                case "3":
                    AddItem();
                    break;

                case "4":
                    FindItem();
                    break;

                case "5":
                    ViewSimDetails();
                    break;

                case "6":
                    ViewWorldState();
                    break;

                case "7":
                    AdvanceDay();
                    break;

                case "8":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("*** WELCOME TO LIFE SIMULATOR ***");
        Console.WriteLine("Shape your sim and bring it to life");
        Console.WriteLine();
        Console.WriteLine("1. Create a Sim");
        Console.WriteLine("2. Assign a Specialization");
        Console.WriteLine("3. Add an Item");
        Console.WriteLine("4. Find an Item");
        Console.WriteLine("5. View Sim Details");
        Console.WriteLine("6. View World Details");
        Console.WriteLine("7. Advance Day");
        Console.WriteLine("8. Exit");
        Console.WriteLine();
        Console.Write("Select an option: ");
       
    }



    private void ViewWorldState()
    {
        Console.WriteLine($"{_currentSim}'s World Details:");
        Console.WriteLine();
        Console.WriteLine($"{_currentSim}'s Neighbourhood: {_world.NeighbourhoodName}");
        Console.WriteLine($"Current Day: {_world.CurrentDay}");
        Console.WriteLine($"Season: {_world.CurrentSeason}");
    }

    private void AdvanceDay()
    {
        _world.AdvanceDay();

        Console.WriteLine("A day has passed.");
        Console.WriteLine();
        Console.WriteLine($"Current Day: {_world.CurrentDay}");
        Console.WriteLine($"Season: {_world.CurrentSeason}");
    }
    
   private void CreateSim()
    {
        Console.WriteLine("Create your sim:");
        Console.WriteLine();
        Console.Write("Enter Sim's name: ");
        string name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Select Sim type:");
        Console.WriteLine();
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Professional");
        Console.WriteLine("3. Athlete");
        Console.WriteLine();
        string choice = Console.ReadLine();

        string character = "";

        switch (choice)
        {
            case "1":
                character = "student";
                break;

            case "2":
                character = "professional";
                break;

            case "3":
                character = "athlete";
                break;

            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        _currentSim = _simFactory.CreateSim(character, name);

        Console.WriteLine("Sim created successfully.");
    }

    private void ViewSimDetails()
    {
        if (_currentSim == null)
        {
            Console.WriteLine("No Sim has been created yet.");
            return;
        }

        Console.WriteLine("Sim Details:");
        Console.WriteLine();
        Console.WriteLine($"Name: {_currentSim.Name}");
        Console.WriteLine( $"{_currentSim.Name} says: {_currentSim.Speak()}");
        Console.WriteLine($"Sim Type: {_currentSim.SimType}"); 
        Console.WriteLine($"Specialization: {_currentSim.Specialization}");
        Console.WriteLine($"{_currentSim.Name}'s professional summary: {_currentSim.Act()}");
        Console.WriteLine($"Health: {_currentSim.Health}");
        Console.WriteLine($"Defense: {_currentSim.Defense}");
        Console.WriteLine($"Speed: {_currentSim.Speed}");
        Console.WriteLine($"Strength: {_currentSim.Strength}");
        Console.WriteLine($"Intellect: {_currentSim.Intellect}");
        Console.WriteLine($"Agility: {_currentSim.Agility}");

        Console.WriteLine("Items:");

        _currentSim.Inventory.DisplayItems();
    }

    private void AddItem()
    {
        if (_currentSim == null)
        {
            Console.WriteLine("No Sim has been created yet.");
            return;
        }
        Console.WriteLine("Add an item to your sim: ");
        Console.WriteLine();
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        _currentSim.Inventory.AddItem(itemName);

        Console.WriteLine($"{itemName} added successfully.");
    }

    private void FindItem()
    {
        if (_currentSim == null)
        {
            Console.WriteLine("No Sim has been created yet.");
            return;
        }

        Console.WriteLine("Find an item:");
        Console.WriteLine();
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Item item = _currentSim.Inventory.FindItem(itemName);

        if (item == null)
        {
            Console.WriteLine("Item not found.");
        }
        else
        {
            Console.WriteLine($"{item.Name} found.");
        }
    }

    private void AssignSpecialization()
    {
        if (_currentSim == null)
        {
            Console.WriteLine("No Sim has been created yet.");
            return;
        }

        string? choice;

        if (_currentSim is Student)
        {
            Console.WriteLine("Select a Specialization:");
            Console.WriteLine();
            Console.WriteLine("1. Software Development");
            Console.WriteLine("2. Business");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _currentSim =
                        new SoftwareDevelopmentDecorator(_currentSim);
                    break;

                case "2":
                    _currentSim =
                        new BusinessDecorator(_currentSim);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }
        else if (_currentSim is Professional)
        {
            Console.WriteLine("Select a specialization:");
            Console.WriteLine();
            Console.WriteLine("1. Developer");
            Console.WriteLine("2. Project Manager");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _currentSim =
                        new DeveloperDecorator(_currentSim);
                    break;

                case "2":
                    _currentSim =
                        new ProjectManagerDecorator(_currentSim);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }
        else if (_currentSim is Athlete)
        {
            Console.WriteLine("Select a specialization:");
            Console.WriteLine();
            Console.WriteLine("1. Cyclist");
            Console.WriteLine("2. Swimmer");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _currentSim =
                        new CyclistDecorator(_currentSim);
                    break;

                case "2":
                    _currentSim =
                        new SwimmerDecorator(_currentSim);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }

        Console.WriteLine("Specialization assigned successfully.");
    }






}