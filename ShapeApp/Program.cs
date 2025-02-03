using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ShapeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure => configure.AddConsole())
                .AddScoped<ShapesController>()
                .BuildServiceProvider();

            var shapesController = serviceProvider.GetRequiredService<ShapesController>();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

            try
            {
                shapesController.ShowShapesMenu();
            }
            catch (Exception ex)
            {
                logger.LogError($"ShapeApp encountered an error: {ex.Message}");
            }
        }
    }
}