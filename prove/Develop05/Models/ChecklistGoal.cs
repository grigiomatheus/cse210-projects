using Develop05.Enums;

namespace Develop05.Models
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(int id, GoalType type, string name, string description, string points, int completed, int target, int bonus) : base(id, type, name, description, points)
        {
            _amountCompleted = completed;
            _target = target;
            _bonus = bonus;
        }

        public override bool IsComplete()
        {
            return _amountCompleted == _target;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;

            if (IsComplete())
            {
                SetPoints(GetPoints() + _bonus);
            }
        }

        public override string GetDetailsString() => $"{base.GetDetailsString()} -- Currently completed {_amountCompleted}/{_target}.";

        public override string GetStringRepresentation()
        {
            return $"{GetId()}|{GetGoalType()}|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
        }
    }
}
