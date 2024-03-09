using System.Text.Json;

namespace Develop02.Models
{
    public class Journal
    {
        public List<Entry> _entries { get; set; } = new List<Entry>();

        public void SetAlreadySavedEntries(List<Entry> entries) => entries.ForEach(x => x.isAlreadySaved = true);

        public void AddEntry(Entry entry) => _entries.Add(entry);

        public void RemoveEntry(int index) => _entries.RemoveAt(index);

        public void DisplayAll()
        {
            int entriesLength = _entries.Count;

            if (entriesLength == 0)
            {
                Console.WriteLine("Nothing to display.");
                return;
            }

            for (int i = 0; i < entriesLength; i++)
            {
                Console.Write($"{i + 1}. ");
                _entries[i].Display();
            }
        }

        public void SaveToFile(string filename)
        {
            LoadFromFile(filename);

            string baseDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = baseDirectory.Substring(0, baseDirectory.IndexOf("bin"));
            string filePath = Path.Combine(projectDirectory, "Journals", $"{filename}.json");

            var entriesToSave = _entries.Where(x => !x.isAlreadySaved).ToList();
            SetAlreadySavedEntries(entriesToSave);

            File.WriteAllText(filePath, JsonSerializer.Serialize(entriesToSave));
        }

        public bool LoadFromFile(string filename)
        {
            string baseDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = baseDirectory.Substring(0, baseDirectory.IndexOf("bin"));
            string filePath = Path.Combine(projectDirectory, "Journals", $"{filename}.json");

            bool fileExists = File.Exists(filePath);

            if (!fileExists)
                return false;

            string fileContent = File.ReadAllText(filePath);

            if (!string.IsNullOrEmpty(fileContent))
            {
                var fileEntries = JsonSerializer.Deserialize<List<Entry>>(fileContent);

                fileEntries.AddRange(_entries.Where(x => !fileEntries.Exists(y => y._id == x._id)));
                _entries = fileEntries.OrderByDescending(x => x._date).ToList();
            }

            return true;
        }

        public void DisplayFiles()
        {
            string baseDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = baseDirectory.Substring(0, baseDirectory.IndexOf("bin"));
            string directoryPath = Path.Combine(projectDirectory, "Journals");

            IEnumerable<string> files = Directory.GetFiles(directoryPath, "*.json");

            Console.WriteLine("Files: \n");

            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
    }
}
