using Poc.DecoratorPattern.Dto;

namespace Poc.DecoratorPattern.Decorator;

public class PredictTimeDecorator : IPredictTime
{
    private IPredictTime _predictTime;
    
    public PredictTimeDecorator(IPredictTime predictTime)
    {
        _predictTime = predictTime;
    }
    
    //This service is the main service to make inherit by to all your decorators
    public virtual WeatherForecast GetWeatherForecast(DateOnly date, int temperatureC, string? summary)
    {
        return _predictTime.GetWeatherForecast(date, temperatureC, summary);
    }
}