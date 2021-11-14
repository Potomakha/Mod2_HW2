using Mod2_HW2.Services;

namespace Mod2_HW2.Models
{
    public class Device
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public static Currency Currency => ConfigurationService.GetCurrency();
    }
}
