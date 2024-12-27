using Poc.DecoratorPattern.Dto;

namespace Poc.DecoratorPattern.Decorator;

public class PredictTimeAddFreezeDecorator : PredictTimeDecorator
{
    public PredictTimeAddFreezeDecorator(IPredictTime predictTime) : base(predictTime)
    {
    }

    public override WeatherForecast GetWeatherForecast(DateOnly date, int temperatureC, string? summary)
    {
        //Start base service + Add freeze thread After
        var weatherForecasts = base.GetWeatherForecast(date, temperatureC, summary);
        Thread.Sleep(200);
        return weatherForecasts;
    }
}