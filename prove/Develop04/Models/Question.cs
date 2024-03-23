namespace Develop04.Models
{
    public class Question
    {
        private Guid _id;

        private string _question { get; }

        private bool _alreadyShowed;

        public Question(string question)
        {
            _id = new Guid();
            _question = question;
            _alreadyShowed = false;
        }

        public string GetQuestion() => _question;

        public Guid GetGuid() => _id;

        public bool IsAlreadyShowed() => _alreadyShowed;

        public void SetAlreadyShowed() => _alreadyShowed = true;
    }
}
