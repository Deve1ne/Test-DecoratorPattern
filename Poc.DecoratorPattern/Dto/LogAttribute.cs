using System.Reflection;

namespace Poc.DecoratorPattern.Dto;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class LogAttribute : Attribute
{
    public void Log(MethodBase method, object[] parameters, object result, TimeSpan duration)
    {
        var methodName = method.Name;
        var parameterInfo = string.Join(", ", parameters.Select(p => p?.ToString() ?? "null"));
        var resultInfo = result?.ToString() ?? "null";

        Console.WriteLine($"Method: {methodName}");
        Console.WriteLine($"Parameters: {parameterInfo}");
        Console.WriteLine($"Result: {resultInfo}");
        Console.WriteLine($"Execution Time: {duration.TotalMilliseconds} ms");
        Console.WriteLine(new string('-', 50));
    }
}