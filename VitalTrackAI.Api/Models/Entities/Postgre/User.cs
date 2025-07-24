namespace VitalTrackAI.Api.Entities.Postgre;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
}