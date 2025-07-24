namespace VitalTrackAI.Api.Entities.Postgre;

public class MenstrualCycleEntry
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}