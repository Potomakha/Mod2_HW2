using Mod2_HW2.Services;

namespace Mod2_HW2.Models
{
    public class Basket
    {
        private static readonly Basket Instance = new Basket();
        private readonly int _capacity;
        public Device[] Devices { get; set; }
        static Basket()
        {
        }

        private Basket()
        {
            _capacity = ConfigurationService.GetBasketLenght();
        }

        public static Basket GetInstance
        {
            get
            {
                return Instance;
            }
        }


    }
}
