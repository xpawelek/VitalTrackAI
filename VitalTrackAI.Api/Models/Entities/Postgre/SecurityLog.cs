using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Entities.Postgre;

public class SecurityLog
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string EventType { get; set; }
    public string IpAddress { get; set; }
    public string DeviceInfo { get; set; }
    public DateTime TimeStamp { get; set; }
    public ApplicationUser User { get; set; }
}