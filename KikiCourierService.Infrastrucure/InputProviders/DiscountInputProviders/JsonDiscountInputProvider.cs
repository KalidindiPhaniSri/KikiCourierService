using System.Text.Json;
using KikiCourierService.KikiCourierService.BLL.Interfaces;
using KikiCourierService.KikiCourierService.BLL.Models;

namespace KikiCourierService.KikiCourierService.Infrastructure.InputProviders.DiscountInputProviders
{
    public class JsonDiscountInputProvider : IDiscountRules
    {
        private readonly Dictionary<string, DiscountRule> _discountRulesData;
        public IReadOnlyDictionary<string, DiscountRule> DiscountRulesData => _discountRulesData;

        public JsonDiscountInputProvider(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var rules = JsonSerializer.Deserialize<Dictionary<string, DiscountRule>>(json);
            _discountRulesData = rules ?? [ ];
        }

        public DiscountRule? GetRule(string coupon)
        {
            if (_discountRulesData.TryGetValue(coupon, out var rule))
            {
                return rule;
            }
            return null;
        }
    }
}
