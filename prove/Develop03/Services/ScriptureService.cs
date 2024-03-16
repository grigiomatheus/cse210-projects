using Develop03.Models;

namespace Develop03.Services
{
    public class ScriptureService
    {
        private readonly List<Scripture> _scriptures;

        public ScriptureService()
        {
            _scriptures = new List<Scripture>();
            PopulateScriptures();
        }

        public void PopulateScriptures()
        {
            var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            _scriptures.Add(scripture);

            scripture = new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.");
            _scriptures.Add(scripture);

            scripture = new Scripture(new Reference("2 Nephi", 2, 25, 26), "Adam fell that men might be; and men care, that they might have joy. And the Messiah cometh in the fulness of time, that he may bredeem the children of men from the fall.");
            _scriptures.Add(scripture);

            scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on. your own understanding; in all your ways submit to. Him, and He will make your paths straight.");
            _scriptures.Add(scripture);

            scripture = new Scripture(new Reference("Isaiah", 1, 18), "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.");
            _scriptures.Add(scripture);

            scripture = new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
            _scriptures.Add(scripture);
        }

        public Scripture GetRandomScripture()
        {
            Random random = new Random();
            return _scriptures[random.Next(_scriptures.Count)];
        }
    }
}
