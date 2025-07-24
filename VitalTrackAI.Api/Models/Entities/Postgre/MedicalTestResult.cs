namespace VitalTrackAI.Api.Entities.Postgre;

public class MedicalTestResult
{
    public int Id { get; set; }
    public int MedicalTestId { get; set; }
    public string ResultLabel { get; set; }
    public string Units { get; set; }
    public double Result { get; set; }
    public double ReferenceMinResult { get; set; }
    public double ReferenceMaxResult { get; set; }
}