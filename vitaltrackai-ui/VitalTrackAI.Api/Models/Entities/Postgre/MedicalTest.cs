using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Entities.Postgre;

public class MedicalTest
{
    public int Id { get; set; }
    //which user has been examined
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public string Name { get; set; }  
    public DateTime Date { get; set; }
    public string Notes { get; set; }
    //encrypted
    public ICollection<MedicalTestResult> Results { get; set; }
}