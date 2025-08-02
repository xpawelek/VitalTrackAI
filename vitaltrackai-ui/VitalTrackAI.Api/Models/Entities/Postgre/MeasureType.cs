namespace VitalTrackAI.Api.Entities.Postgre;

public class MeasureType
{
    public int Id { get; set; }
    //type of mesaurement
    public string Name { get; set; }
    //category - connected to which part of body
    public string Category { get; set; }
    //what does it examine
    public string Description { get; set; }
    public double ReferenceMinResult { get; set; }
    public double ReferenceMaxResult { get; set; }
}