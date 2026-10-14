namespace LifeSimulator.Engine;
using LifeSimulator.Characters;
using LifeSimulator.Decorators;
using LifeSimulator.Factories;
using LifeSimulator.Inventory;

public class GameController
{
    private ISim? _currentCharacter;

    private readonly ISimFactory _simFactory = new LifeSimFactory();

    private readonly SimulationWorld _world = SimulationWorld.GetInstance();

    public void RunApp()
    {
        bool isRunning = true;

        while (isRunning)
        {
            DisplayMenu();

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateCharacter();
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
                    ViewCharacterDetails();
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
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("=== LIFE SIMULATOR ===");
        Console.WriteLine("1. Create Character");
        Console.WriteLine("2. Assign Specialization");
        Console.WriteLine("3. Add Item");
        Console.WriteLine("4. Find Item");
        Console.WriteLine("5. View Character Details");
        Console.WriteLine("6. View World State");
        Console.WriteLine("7. Advance Day");
        Console.WriteLine("8. Exit");
        Console.Write("Select an option: ");
    }



    private void ViewWorldState()
    {
        Console.WriteLine($"Neighbourhood: {_world.NeighbourhoodName}");
        Console.WriteLine($"Current Day: {_world.CurrentDay}");
        Console.WriteLine($"Season: {_world.CurrentSeason}");
    }

    private void AdvanceDay()
    {
        _world.AdvanceDay();

        Console.WriteLine("A day has passed.");
        Console.WriteLine($"Current Day: {_world.CurrentDay}");
        Console.WriteLine($"Season: {_world.CurrentSeason}");
    }
    
   private void CreateCharacter()
    {
        Console.Write("Enter character name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select character type:");
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

        _currentCharacter = _simFactory.CreateSim(character, name);

        Console.WriteLine("Character created successfully.");
    }

    private void ViewCharacterDetails()
    {
        if (_currentCharacter == null)
        {
            Console.WriteLine("No character has been created yet.");
            return;
        }

        _currentCharacter.PrintDetails();
    }

   
    private void AddItem()
    {
        if (_currentCharacter == null)
        {
            Console.WriteLine("No character has been created yet.");
            return;
        }

        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        _currentCharacter.Inventory.AddItem(itemName);

        Console.WriteLine($"{itemName} added successfully.");
    }

    private void FindItem()
    {
        if (_currentCharacter == null)
        {
            Console.WriteLine("No character has been created yet.");
            return;
        }

        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Item item = _currentCharacter.Inventory.FindItem(itemName);

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
        if (_currentCharacter == null)
        {
            Console.WriteLine("No character has been created yet.");
            return;
        }

        string? choice;

        if (_currentCharacter is Student)
        {
            Console.WriteLine("Select a specialization:");
            Console.WriteLine("1. Software Development");
            Console.WriteLine("2. Business");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _currentCharacter =
                        new SoftwareDevelopmentDecorator(_currentCharacter);
                    break;

                case "2":
                    _currentCharacter =
                        new BusinessDecorator(_currentCharacter);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }
        else if (_currentCharacter is Professional)
        {
            Console.WriteLine("Select a specialization:");
            Console.WriteLine("1. Developer");
            Console.WriteLine("2. Project Manager");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _currentCharacter =
                        new DeveloperDecorator(_currentCharacter);
                    break;

                case "2":
                    _currentCharacter =
                        new ProjectManagerDecorator(_currentCharacter);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }
        else if (_currentCharacter is Athlete)
        {
            Console.WriteLine("Select a specialization:");
            Console.WriteLine("1. Cyclist");
            Console.WriteLine("2. Swimmer");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _currentCharacter =
                        new CyclistDecorator(_currentCharacter);
                    break;

                case "2":
                    _currentCharacter =
                        new SwimmerDecorator(_currentCharacter);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }

        Console.WriteLine("Specialization assigned successfully.");
    }






}