using Mod2_HW2.Services;

namespace Mod2_HW2.Models
{
    public class Basket
    {
        private static readonly Basket _instance = new Basket();
        private readonly int _capacity;
        static Basket()
        {
        }

        private Basket()
        {
            _capacity = ConfigurationService.GetBasketLenght();
        }

        public Device[] Devices { get; private set; }
        public static Basket Instance => _instance;

        public void AddProducts(Device[] devices)
        {
            Devices = devices;
        }
    }
}
