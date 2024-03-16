using System.Text;

namespace Develop03.Models
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ')
                .Select(x => new Word(x))
                .ToList();
        }

        public void HideRandomWords(int numberToHide)
        {
            var wordsToHide = _words.Where(x => !x.IsHidden()).ToList();

            Random random = new Random();

            for (int i = 0; i <= numberToHide; i++)
            {
                int index = random.Next(wordsToHide.Count);
                wordsToHide[index].Hide();
            }
        }

        public string GetDisplayText()
        {
            StringBuilder displayText = new StringBuilder();

            displayText.Append($"{_reference.GetDisplayText()} ");

            foreach (Word word in _words)
            {
                displayText.Append(word.GetDisplayText() + " ");
            }

            return displayText
                .ToString()
                .TrimEnd('.');
        }

        public bool IsCompletelyHidden() => _words.TrueForAll(x => x.IsHidden());
    }
}
