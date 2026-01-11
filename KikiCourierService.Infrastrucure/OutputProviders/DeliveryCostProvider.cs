using KikiCourierService.KikiCourierService.BLL.Models;

namespace KikiCourierService.KikiCourierService.Infrastructure.OutputProviders
{
    public class DeliveryCostProvider
    {
        private readonly IReadOnlyList<PackageCostResult> _packageCostResults;

        public DeliveryCostProvider(IReadOnlyList<PackageCostResult> packageCostResults)
        {
            _packageCostResults = packageCostResults;
        }

        public void PrintDeliveryCost()
        {
            foreach (PackageCostResult result in _packageCostResults)
            {
                Console.WriteLine(
                    $"{result.PackageId} {result.DiscountAmount} {result.DeliveryCost}"
                );
            }
        }
    }
}
