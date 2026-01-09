using KikiCourierService.KikiCourierService.BLL.Interfaces;

namespace KikiCourierService.KikiCourierService.BLL
{
    public class PackageReader(IPackageInputProvider input)
    {
        private readonly IPackageInputProvider _input = input;
        private readonly List<Package> _packages =  [ ];
        public double BaseDeliveryPrice { get; private set; }
        public IReadOnlyList<Package> Packages => _packages;

        public void ReadInput()
        {
            ReadBaseDeliveryPrice();
            ReadPackages();
        }

        public int GetPackagesCount()
        {
            return _packages.Count;
        }

        private double ReadDouble(string fieldName)
        {
            if (!double.TryParse(_input.ReadLine(), out double value))
            {
                throw new InvalidDataException($"{fieldName} must be a number");
            }
            return value;
        }

        private int ReadInt(string fieldName)
        {
            if (!int.TryParse(_input.ReadLine(), out int value))
            {
                throw new InvalidDataException($"{fieldName} must be a number");
            }
            return value;
        }

        private void ReadBaseDeliveryPrice()
        {
            BaseDeliveryPrice = ReadDouble("Base delivery price");
        }

        public void AddSinglePackage(string id, int weight, int distance, string couponCode)
        {
            _packages.Add(new Package(id, weight, distance, couponCode));
        }

        private void ReadPackages()
        {
            int count = ReadInt("Packages count");
            for (int i = 0; i < count; i++)
            {
                string id = _input.ReadLine();
                int weight = ReadInt("Package weight");
                int distance = ReadInt("Delivery distance");
                string couponCode = _input.ReadLine();
                AddSinglePackage(id, weight, distance, couponCode);
            }
        }
    }
}
