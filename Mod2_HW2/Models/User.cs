using Mod2_HW2.Models;
using Mod2_HW2.Services;
namespace Mod2_HW2
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }

        private readonly Basket _basket;
        private readonly OrderService _orderService;
        public User()
        {
            _basket = Basket.GetInstance;
            _orderService = new OrderService();
        }

        public void AddProducts(Device[] devices)
        {
            _basket.Devices = devices;
        }

        public void MakeOrder(User user)
        {
            _orderService.CreateOrder(user);
        }
    }
}
