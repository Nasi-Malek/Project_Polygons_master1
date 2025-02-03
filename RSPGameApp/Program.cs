using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace RSPGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure => configure.AddConsole())
                .AddScoped<GameHandler>()
                .BuildServiceProvider();

            var gameHandler = serviceProvider.GetRequiredService<GameHandler>();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

            try
            {
                gameHandler.PlayGame();
            }
            catch (Exception ex)
            {
                logger.LogError($"RSPGameApp encountered an error: {ex.Message}");
            }
        }
    }
}