using Microsoft.AspNetCore.Identity;
using VitalTrackAI.Api.Entities.Postgre;

namespace VitalTrackAI.Api.Models.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
    
    public ICollection<DailyMeasures> DailyMeasures { get; set; }
    public ICollection<MedicalTest> MedicalTests { get; set; }
    public ICollection<MenstrualCycleEntry> MenstrualCycles { get; set; }
    public ICollection<SecurityLog> SecurityLogs { get; set; }
}