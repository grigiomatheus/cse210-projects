using Foundation4.Models;

class Program
{
    static void Main(string[] args)
    {
        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2024, 12, 15, 10, 0, 0), 90, 20);
        RunningActivity runningActivity = new RunningActivity(new DateTime(2024, 12, 15, 10, 0, 0), 90, 50);
        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2024, 12, 15, 10, 0, 0), 90, 20);

        List<Activity> activities = new List<Activity> { cyclingActivity, runningActivity, swimmingActivity };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}