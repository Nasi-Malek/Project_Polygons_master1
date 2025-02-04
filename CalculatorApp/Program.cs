using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure => configure.AddConsole())
                .AddScoped<CalculatorHandler>()
                .BuildServiceProvider(); 

            var calculatorHandler = serviceProvider.GetRequiredService<CalculatorHandler>();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

            try
            {
                calculatorHandler.ShowCalculatorMenu();
            }
            catch (Exception ex)
            {
                logger.LogError($"CalculatorApp encountered an error: {ex.Message}");
            }
        }
    }
}