using Develop05.Enums;
using Develop05.Models;

namespace Develop05.Services
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;
        private FileManager _fileManager;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
            _fileManager = new FileManager();
        }

        public void Start()
        {
            while (true)
            {
                DisplayMainMenu();

                if (!TryGetValidInput(7, out int userInput))
                    continue;

                switch (userInput)
                {
                    case (int)MenuOptionType.CreateGoal:
                        CreateGoal();
                        break;
                    case (int)MenuOptionType.ListGoals:
                        ListGoalsDetails();
                        break;
                    case (int)MenuOptionType.SaveGoals:
                        SaveGoals();
                        break;
                    case (int)MenuOptionType.LoadGoals:
                        LoadGoals();
                        break;
                    case (int)MenuOptionType.RecordEvent:
                        RecordEvent();
                        break;
                    case (int)MenuOptionType.Clear:
                        Console.Clear();
                        break;
                    case (int)MenuOptionType.Quit:
                        return;
                }

            }
        }

        public void DisplayPlayerInfo() => Console.WriteLine($"\nYou have {_score} points.\n");

        public void ListGoalNames()
        {
            if (IsUnaccomplishedGoals())
                _goals.Where(x => !x.IsComplete()).ToList().ForEach(x => Console.WriteLine($"{x.GetListedNameString()}"));
            else
                Console.WriteLine("The list of unaccomplished goals is empty.");
        }

        public void ListGoalsDetails()
        {
            if (_goals.Any())
            {
                Console.WriteLine("\nThe goals are:");
                _goals.ForEach(x => Console.WriteLine($"{x.GetDetailsString()}"));
            }
            else
                Console.WriteLine("The list of goals is empty.");
        }

        public void CreateGoal()
        {
            DisplayGoalTypes();

            if (!TryGetValidInput(3, out var goalType))
                return;

            Console.Write("What is the name of your goal? ");
            var goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            var goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            var goalPoints = Console.ReadLine();

            Goal goal = null;

            switch (goalType)
            {
                case (int)GoalType.SimpleGoal:
                    goal = new SimpleGoal(_goals.Count() + 1, GoalType.SimpleGoal, goalName, goalDescription, goalPoints);
                    break;
                case (int)GoalType.EternalGoal:
                    goal = new EternalGoal(_goals.Count() + 1, GoalType.EternalGoal, goalName, goalDescription, goalPoints);
                    break;
                case (int)GoalType.CheckListGoal:
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    var target = Console.ReadLine();

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    var bonus = Console.ReadLine();

                    goal = new ChecklistGoal(_goals.Count() + 1, GoalType.CheckListGoal, goalName, goalDescription, goalPoints, 0, int.Parse(target), int.Parse(bonus));
                    break;

            }

            _goals.Add(goal);
        }

        public void RecordEvent()
        {
            ListGoalNames();

            if (IsUnaccomplishedGoals())
            {
                Console.Write("\nWhich goal did you accomplished: ");

                if (TryGetValidInput(_goals.Count(), out int userInput))
                {
                    Goal goalAccomplished = _goals[userInput - 1];

                    if (goalAccomplished.IsComplete())
                    {
                        Console.WriteLine("Invalid input. Please enter a valid choice from menu.");
                        return;
                    }

                    goalAccomplished.RecordEvent();
                    _score += goalAccomplished.GetPoints();

                    Console.WriteLine($"Congratulations! You have earned {goalAccomplished.GetPoints()} points!");
                }
            }
        }

        public void SaveGoals() => _fileManager.SaveGoalsInFile(_goals, _score);

        public void LoadGoals()
        {
            bool couldLoadGoals = _fileManager.TryLoadGoalsFromFile(out List<Goal> goals, out int score);

            if (couldLoadGoals)
            {
                _score = score;
                _goals = goals;
            }
        }

        private void DisplayGoalTypes()
        {
            Console.WriteLine("\nThe types of goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Select a choice from the menu: ");
        }

        private void DisplayMainMenu()
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Clear Console");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
        }

        private bool TryGetValidInput(int maximumChoices, out int userInput)
        {
            var userInputString = Console.ReadLine();
            var listValidInputs = new List<int>();

            for (int i = 1; i <= maximumChoices; i++)
            {
                listValidInputs.Add(i);
            }

            if (int.TryParse(userInputString, out userInput) && listValidInputs.Contains(userInput))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice from menu.");
                return false;
            }
        }

        private bool IsUnaccomplishedGoals() => _goals.Any(x => !x.IsComplete());
    }
}
