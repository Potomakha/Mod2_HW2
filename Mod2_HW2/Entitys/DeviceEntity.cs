using System;
using Mod2_HW2.Services;

namespace Mod2_HW2.Entitys
{
    public class DeviceEntity
    {
        public DeviceEntity()
        {
            Currency = ConfigurationService.GetCurrency();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
    }
}
