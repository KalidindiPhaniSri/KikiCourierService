using KikiCourierService.KikiCourierService.BLL.Interfaces;

namespace KikiCourierService.KikiCourierService.Infrastructure.InputProviders
{
    public class ConsoleInputProvider : IInputProvider
    {
        public string ReadLine()
        {
            string? input = Console.ReadLine() ?? string.Empty;
            return input;
        }
    }
}
