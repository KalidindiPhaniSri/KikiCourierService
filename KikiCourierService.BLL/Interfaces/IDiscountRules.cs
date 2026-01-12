using KikiCourierService.KikiCourierService.BLL.Models;

namespace KikiCourierService.KikiCourierService.BLL.Interfaces
{
    public interface IDiscountRules
    {
        DiscountRule? GetRule(string coupon);
    }
}
