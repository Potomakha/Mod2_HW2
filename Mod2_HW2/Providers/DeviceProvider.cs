using System;
using Mod2_HW2.Configurations;
using Mod2_HW2.Entitys;

namespace Mod2_HW2.Providers
{
    public class DeviceProvider
    {
        public DeviceEntity[] GetDeviceArray()
        {
            int capacity = BasketConfig.Capacity + 1;
            var deviceArray = new DeviceEntity[capacity];
            for (int i = 0; i < deviceArray.Length; i++)
            {
                deviceArray[i] = new DeviceEntity
                {
                    Id = Guid.NewGuid(),
                    Name = $"device-{i}",
                    Model = new Random().Next().ToString(),
                    Price = new Random().Next(6666)
                };
            }

            return deviceArray;
        }
    }
}
