using Develop05.Enums;

namespace Develop05.Models
{
    public class SimpleGoal : Goal
    {
        private bool _isCompleted = false;

        public SimpleGoal(int id, GoalType type, string name, string description, string points, bool isCompleted = false) : base(id, type, name, description, points) 
        { 
            _isCompleted = isCompleted;
        }

        public override void RecordEvent()
        {
            _isCompleted = true;
        }

        public override bool IsComplete() => _isCompleted;

        public override string GetStringRepresentation()
        {
            return $"{GetId()}|{GetGoalType()}|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isCompleted}";
        }
    }
}
