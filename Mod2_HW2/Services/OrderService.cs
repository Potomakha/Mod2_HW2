using System.Text;
using Mod2_HW2.Models;

namespace Mod2_HW2.Services
{
    public class OrderService
    {
        private readonly Basket _basket;
        private decimal _orderCost;
        public OrderService()
        {
            _basket = Basket.Instance;
            _orderCost = 0;
        }

        public void CreateOrder(User user)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{user.Name}`s order");
            stringBuilder.AppendLine("Order items:");
            foreach (var item in _basket.Devices)
            {
                stringBuilder.AppendLine($"{item.Name} |---> Price: {item.Price} {Device.Currency}");
                _orderCost += item.Price;
            }

            stringBuilder.AppendLine($"Send message to email {user.Email}.");
            stringBuilder.AppendLine($"Order Price is {_orderCost} {Device.Currency}");
            NotificationService.SendMessage(user.Email, stringBuilder.ToString());
        }
    }
}
