using System.Diagnostics;
using Castle.DynamicProxy;
using System.Reflection;
using Poc.DecoratorPattern.Dto;

namespace Poc.DecoratorPattern.Proxy;

public class ProxyLogger : IInterceptor
{
    
        public void Intercept(IInvocation invocation)
        {
            var stopwatch = Stopwatch.StartNew();

            // Log des paramètres d'entrée
            var method = invocation.MethodInvocationTarget ?? invocation.Method;
            var logAttribute = method.GetCustomAttribute<LogAttribute>();

            try
            {
                // Exécution de la méthode réelle
                invocation.Proceed();

                stopwatch.Stop();

                // Log de la sortie si l'attribut Log est présent
                logAttribute?.Log(method, invocation.Arguments, invocation.ReturnValue, stopwatch.Elapsed);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Console.WriteLine($"Method {method.Name} threw an exception: {ex}");
                throw;
            }
        }
    
}