using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Entities.Postgre;

public class DailyMeasures
{
    public int Id { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public int DailyCaloriesIntake {get; set;}
    public double Carbs { get; set; }
    public double Fats { get; set; }
    public double Proteins { get; set; }
    public double SleepHours { get; set; }
    public double WaterIntake { get; set; }
    public int SubjectiveMood { get; set; }
    public int Steps { get; set; }
    public string DailyHealthNotes { get; set; }
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
}