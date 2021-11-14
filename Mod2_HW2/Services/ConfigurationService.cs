using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_HW2.Services
{
    public static class ConfigurationService
    {
        private static int _basketLenght = 10;
        public static Currency GetCurrency()
        {
            return Currency.UAH;
        }

        public static int GetBasketLenght()
        {
            return _basketLenght;
        }
    }
}
