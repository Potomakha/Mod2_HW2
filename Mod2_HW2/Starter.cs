using System;
using Mod2_HW2.Models;
using Mod2_HW2.Services;

namespace Mod2_HW2
{
    public class Starter
    {
        private readonly DeviceService _deviceService;
        private readonly User _user;
        private readonly Basket _basket;
        private readonly OrderService _orderService;

        public Starter()
        {
            _deviceService = new DeviceService();
            _user = new User()
            {
                Email = "useremail@gmail.com",
                Name = "Ivan Ivanov",
                PhoneNumber = 380123212321
            };
            _basket = Basket.Instance;
            _orderService = new OrderService();
        }

        public void Run()
        {
            var devices = _deviceService.CreateDeviceArray();
            int toBuyCount = new Random().Next(1, 11);
            var toBuy = new Device[toBuyCount];

            for (int i = 0; i < toBuyCount; i++)
            {
                toBuy[i] = devices[i];
            }

            _basket.AddProducts(toBuy);
            _orderService.CreateOrder(_user);
    }
    }
}
