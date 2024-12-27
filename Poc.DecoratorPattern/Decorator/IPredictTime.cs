using Poc.DecoratorPattern.Dto;

namespace Poc.DecoratorPattern.Decorator;

public interface IPredictTime
{
    [Log]
    WeatherForecast GetWeatherForecast(DateOnly Date, int TemperatureC, string? Summary);

}