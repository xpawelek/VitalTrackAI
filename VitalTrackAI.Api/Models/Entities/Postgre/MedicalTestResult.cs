namespace VitalTrackAI.Api.Entities.Postgre;

public class MedicalTestResult
{
    public int Id { get; set; }
    public int MedicalTestId { get; set; }
    public MedicalTest MedicalTest { get; set; }
    public int MeasureTypeId { get; set; }
    public MeasureType MeasureType { get; set; }
    public string ResultLabel { get; set; }
    public string Units { get; set; }
    //ecrypted
    public double Result { get; set; }
}