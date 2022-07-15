namespace AdvancedSecuritySample;

public class WeatherForecast {
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    
    private static Random generator;

     public int RandomNumber()
    {
        // This should probably have said "generator ?? new Random()".
        generator = generator ?? generator;
        return generator.Next();
    }

}