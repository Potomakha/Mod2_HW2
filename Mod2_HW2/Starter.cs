using System;
using Mod2_HW2.Models;
using Mod2_HW2.Services;

namespace Mod2_HW2
{
    public class Starter
    {
        private readonly DeviceService _deviceService;
        private readonly User _user;

        public Starter()
        {
            _deviceService = new DeviceService();
            _user = new User()
            {
                Email = "useremail@gmail.com",
                Name = "Ivan Ivanov",
                PhoneNumber = 380123212321
            };
        }

        public void Run()
        {
            Device[] devices = _deviceService.CreateDeviceArray();
            int toBuyCount = new Random().Next(1, 11);
            Device[] toBuy = new Device[toBuyCount];

            for (int i = 0; i < toBuyCount; i++)
            {
                toBuy[i] = devices[i];
            }

            _user.AddProducts(toBuy);
            _user.MakeOrder(_user);
    }
    }
}
