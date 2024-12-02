using System.Diagnostics.Metrics;

public class GreeterMeter
{
    private readonly Meter greeterMeter;
    private readonly Counter<int> greeterCounter;
    
    public GreeterMeter()
    {
        greeterMeter = new Meter("BlazorWebAppMovies", "1.0");
        greeterCounter = greeterMeter.CreateCounter<int>("counter.count", description: "Counts how often the Counter component was clicked by a user.");
    }

    public void IncrementCounter()
    {
        greeterCounter.Add(1);
    }
}