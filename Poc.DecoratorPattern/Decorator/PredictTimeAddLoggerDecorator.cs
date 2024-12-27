using Poc.DecoratorPattern.Dto;

namespace Poc.DecoratorPattern.Decorator;

public class PredictTimeAddLoggerDecorator :PredictTimeDecorator
{
    public PredictTimeAddLoggerDecorator(IPredictTime predictTime) : base(predictTime)
    {
    }
    
    public override WeatherForecast GetWeatherForecast(DateOnly date, int temperatureC, string? summary)
    {
        //Start base service + Add logger before and after
        Console.WriteLine("Start GetWeatherForecast");
        var weatherForecasts = base.GetWeatherForecast(date, temperatureC, summary);
        Console.WriteLine("End GetWeatherForecast");
        return weatherForecasts;
    }
}