namespace VitalTrackAI.Api.Entities.Mongo;

public class AiRequest
{
    public int Id { get; set; }
    public int MedicalTestId { get; set; }
    public int UserId { get; set; }
    public DateTime RequestDate { get; set; }
    public string Context { get; set; }
    public string AiResponseText { get; set; }
}