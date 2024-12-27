using Castle.DynamicProxy;
using Poc.DecoratorPattern.Decorator;
using Poc.DecoratorPattern.Proxy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add DI
builder.Services.AddTransient<IPredictTime, PredictTime>();

//builder.Services.AddTransient<IInterceptor, ProxyLogger>();

//add Decorator to service/interface DI
builder.Services.Decorate<IPredictTime, PredictTimeAddFreezeDecorator>();
builder.Services.Decorate<IPredictTime, PredictTimeAddLoggerDecorator>();


/*
builder.Services.AddTransient<IPredictTime>(provider =>
{
    var proxyGenerator = new ProxyGenerator();

    // Récupérer l'instance de Service et l'intercepteur depuis le DI
    var service = provider.GetRequiredService<IPredictTime>();
    var interceptor = provider.GetRequiredService<IInterceptor>();

    // Créer le proxy de l'interface IService avec l'intercepteur
    return proxyGenerator.CreateInterfaceProxyWithTarget(service, interceptor);
});
*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};


app.MapGet("/weatherforecast", (IPredictTime predictTime) =>
    {
       var forecast =  Enumerable.Range(1, 5).Select(index => predictTime.GetWeatherForecast( 
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]));

        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();