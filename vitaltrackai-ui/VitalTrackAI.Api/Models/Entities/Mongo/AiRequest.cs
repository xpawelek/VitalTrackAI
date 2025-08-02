using MongoDB.Bson;

namespace VitalTrackAI.Api.Entities.Mongo;

public class AiRequest
{
    public ObjectId Id { get; set; }               // MongoDB document ID
    public string UserId { get; set; }
    public int MedicalTestId { get; set; } 
    public DateTime RequestDate { get; set; }
    public string UserPrompt { get; set; }
    public string AiResponseText { get; set; }
}