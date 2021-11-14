using System;
using Mod2_HW2.Entitys;

namespace Mod2_HW2.Providers
{
    public class DeviceProvider
    {
        public DeviceEntity[] GetDeviceArray()
        {
            DeviceEntity[] deviceArray = new DeviceEntity[20];
            for (int i = 0; i < deviceArray.Length; i++)
            {
                deviceArray[i] = new DeviceEntity
                {
                    ID = Guid.NewGuid(),
                    Name = $"device-{i}",
                    Model = new Random().Next().ToString(),
                    Price = new Random().Next(6666)
                };
            }

            return deviceArray;
        }
    }
}
