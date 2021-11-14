using Mod2_HW2.Models;

namespace Mod2_HW2
{
    public class User
    {
        private readonly Basket _basket;

        public User()
        {
            _basket = Basket.GetInstance;
        }

        public void AddProducts(Device[] devices)
        {
            _basket.Devices = devices;
        }

        public void MakeOrder()
        {
        }
    }
}
