using Mod2_HW2.Configurations;

namespace Mod2_HW2.Services
{
    public static class ConfigurationService
    {
        public static Currency GetCurrency()
        {
            return ProductConfig.Currency;
        }

        public static int GetBasketLenght()
        {
            return BasketConfig.Capacity;
        }
    }
}
