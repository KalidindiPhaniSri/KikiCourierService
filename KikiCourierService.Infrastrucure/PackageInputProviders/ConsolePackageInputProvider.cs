using KikiCourierService.KikiCourierService.BLL.Interfaces;

namespace KikiCourierService.KikiCourierService.Infrastructure.PackageInputProviders
{
    public class ConsolePackageInputProvider : IPackageInputProvider
    {
        public string ReadLine()
        {
            string? input = Console.ReadLine() ?? string.Empty;
            return input;
        }
    }
}
