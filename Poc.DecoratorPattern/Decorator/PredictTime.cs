using Poc.DecoratorPattern.Dto;

namespace Poc.DecoratorPattern.Decorator;

public class PredictTime : IPredictTime
{
    //Basic Service
    public WeatherForecast GetWeatherForecast(DateOnly date, int temperatureC, string? summary)
    {
        var forecast = new WeatherForecast
        (
            date, temperatureC, summary
        );
        return forecast;
    }
}