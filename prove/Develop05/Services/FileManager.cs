using Develop05.Enums;
using Develop05.Models;

namespace Develop05.Services
{
    public class FileManager
    {
        private const string _folderName = "Goals";

        public bool TryLoadGoalsFromFile(out List<Goal> goals, out int score)
        {
            goals = new List<Goal>();
            score = 0;

            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();

            if (Directory.Exists(_folderName) && File.Exists($"{_folderName}/{fileName}.txt"))
            {
                string[] lines = File.ReadAllLines($"{_folderName}/{fileName}.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == 0)
                    {
                        score = int.Parse(lines[i]);
                        continue;
                    }

                    string line = lines[i];
                    string[] parts = line.Split("|");
                    GoalType type = Enum.Parse<GoalType>(parts[1]);

                    switch (type)
                    {
                        case GoalType.SimpleGoal:
                            goals.Add(new SimpleGoal(int.Parse(parts[0]), GoalType.SimpleGoal, parts[2], parts[3], parts[4], bool.Parse(parts[5])));
                            break;
                        case GoalType.EternalGoal:
                            goals.Add(new EternalGoal(int.Parse(parts[0]), GoalType.EternalGoal, parts[2], parts[3], parts[4]));
                            break;
                        case GoalType.CheckListGoal:
                            goals.Add(new ChecklistGoal(int.Parse(parts[0]), GoalType.CheckListGoal, parts[2], parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                            break;
                    }
                }

                return true;
            }
            else
            {
                Console.WriteLine("File not found.");
                return false;
            }
        }

        public void SaveGoalsInFile(List<Goal> goals, int totalScore)
        {
            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();

            if (!Directory.Exists(_folderName))
            {
                Directory.CreateDirectory(_folderName);
            }

            using (StreamWriter sw = new StreamWriter($"{_folderName}/{fileName}.txt"))
            {
                sw.WriteLine(totalScore);

                foreach (Goal goal in goals)
                {
                    sw.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }
        }
    }
}
