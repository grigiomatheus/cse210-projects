using Develop05.Enums;

namespace Develop05.Models
{
    public abstract class Goal
    {
        private int _id;
        private GoalType _goalType;
        private string _shortName;
        private string _description;
        private int _points;

        public Goal(int id, GoalType type, string name, string description, string points)
        {
            _id = id;
            _goalType = type;
            _shortName = name;
            _description = description;
            _points = int.Parse(points);
        }

        #region Getters and Setters
        public void SetId(int id) => _id = id;
        public int GetId() => _id;

        public string GetGoalType() => _goalType.ToString();

        public string GetShortName() => _shortName;

        public string GetDescription() => _description;


        public int GetPoints() => _points;
        public void SetPoints(int points) => _points = points;
        #endregion


        public abstract void RecordEvent();

        public abstract bool IsComplete();

        public virtual string GetDetailsString() => $"{_id}. {GetCheckBox()} {_shortName} ({_description})";

        private string GetCheckBox()
        {
            if(this.IsComplete())
            {
                return "[X]";
            }
            else
            {
                return "[ ]";
            }
        }

        public abstract string GetStringRepresentation();

        public string GetListedNameString() => $"{_id}. {_shortName}";
    }
}
