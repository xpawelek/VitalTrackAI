namespace VitalTrackAI.Api.Entities.Postgre;

public class MedicalTest
{
    
    public int Id { get; set; }
    public int UserId { get; set; }
    public int MeasureTypeId { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }
}