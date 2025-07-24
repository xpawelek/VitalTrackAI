using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Entities.Postgre;

public class MenstrualCycleEntry
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}