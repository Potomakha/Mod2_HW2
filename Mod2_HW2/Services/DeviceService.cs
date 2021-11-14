using Mod2_HW2.Entitys;
using Mod2_HW2.Models;
using Mod2_HW2.Providers;

namespace Mod2_HW2.Services
{
    public class DeviceService
    {
        private DeviceProvider _deviceProvider;

        public Device[] CreateDeviceArray()
        {
            DeviceEntity[] deviceEntity = _deviceProvider.GetDeviceArray();
            Device[] devices = new Device[deviceEntity.Length];
            for (int i = 0; i < deviceEntity.Length; i++)
            {
                devices[i] = new Device
                {
                    ID = deviceEntity[i].ID.ToString(),
                    Name = deviceEntity[i].Name,
                    Model = deviceEntity[i].Model,
                    Price = deviceEntity[i].Price
                };
            }

            return devices;
        }
    }
}
