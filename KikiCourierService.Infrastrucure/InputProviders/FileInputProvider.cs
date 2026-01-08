using KikiCourierService.KikiCourierService.BLL.Interfaces;

namespace KikiCourierService.KikiCourierService.Infrastructure.InputProviders
{
    public class FileInputProvider(string filePath) : IInputProvider
    {
        private StreamReader _reader = new(filePath);

        public string ReadLine()
        {
            string? value = _reader.ReadLine();
            if (value == null)
            {
                return _reader.ReadLine() ?? throw new EndOfStreamException("End of file reached");
            }
            else if (value == "-")
            {
                return string.Empty;
            }
            return value;
        }
    }
}
