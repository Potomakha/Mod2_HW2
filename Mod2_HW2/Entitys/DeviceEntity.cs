using System;
using Mod2_HW2.Services;

namespace Mod2_HW2.Entitys
{
    public class DeviceEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Currency Currency => ConfigurationService.GetCurrency();
    }
}
