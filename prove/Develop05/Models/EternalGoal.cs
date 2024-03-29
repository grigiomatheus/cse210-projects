using Develop05.Enums;

namespace Develop05.Models
{
    public class EternalGoal : Goal
    {
        public EternalGoal(int id, GoalType type, string name, string description, string points) : base(id, type, name, description, points) { }

        public override bool IsComplete() => false;

        public override void RecordEvent() {}

        public override string GetStringRepresentation()
        {
            return $"{GetId()}|{GetGoalType()}|{GetShortName()}|{GetDescription()}|{GetPoints()}";
        }
    }
}
