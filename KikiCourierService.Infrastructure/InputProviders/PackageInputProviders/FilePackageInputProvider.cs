using KikiCourierService.KikiCourierService.BLL.Interfaces;
<<<<<<< HEAD
using Microsoft.Extensions.Logging;

namespace KikiCourierService.KikiCourierService.Infrastructure.InputProviders.InputProviders
{
    public class FilePackageInputProvider : IPackageInputProvider
    {
        private StreamReader _reader;
        private readonly ILogger<FilePackageInputProvider> _logger;

        public FilePackageInputProvider(string filePath, ILogger<FilePackageInputProvider> logger)
        {
            _logger = logger;
            _logger.LogInformation(
                "Opening the file to read the package input. FilePath={FilePath}",
                filePath
            );
            try
            {
                _reader = new(filePath);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Failed to open the package input file. FilePath={FilePath}",
                    filePath
                );
                throw;
            }
        }
=======

namespace KikiCourierService.KikiCourierService.Infrastructure.InputProviders.PackageInputProviders
{
    public class FilePackageInputProvider(string filePath) : IPackageInputProvider
    {
        private StreamReader _reader = new(filePath);
>>>>>>> courier-service

        public string ReadLine()
        {
            string? value = _reader.ReadLine();
            if (value == null)
            {
<<<<<<< HEAD
                _logger.LogError("Rached to the end of the file");
=======
>>>>>>> courier-service
                return _reader.ReadLine() ?? throw new EndOfStreamException("End of file reached");
            }
            else if (value == "-")
            {
                return string.Empty;
            }
            return value;
        }
<<<<<<< HEAD

        public void Dispose()
        {
            _logger.LogDebug("Closing package input file");
            _reader.Dispose();
        }
=======
>>>>>>> courier-service
    }
}
