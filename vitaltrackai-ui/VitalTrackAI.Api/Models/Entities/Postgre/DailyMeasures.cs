using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Entities.Postgre;

public class DailyMeasures
{
    public int Id { get; set; }
    //update weight daily - can be null
    public double? Weight { get; set; }
    //update height daily - can be null
    public double Height { get; set; }
    //intaken calories - requried
    public int DailyCaloriesIntake {get; set;}
    //intaken carbs - can be null
    public double? Carbs { get; set; }
    //intaken fats - can be null
    public double? Fats { get; set; }
    //intaken proteins - can be null
    public double? Proteins { get; set; }
    //slept hours - required
    public double SleepHours { get; set; }
    //water intake - required
    public double WaterIntake { get; set; }
    //required
    public int SubjectiveMood { get; set; }
    //steps done - can be null
    public int? Steps { get; set; }
    //short description about your feel during the day, your activities etc 
    public string DailyHealthNotes { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}