using System;

namespace Mod2_HW2.Services
{
    public class NotificationService
    {
        public static void SendMessage(string address, string messageText)
        {
            Console.WriteLine($"Send to {address}");
            Console.WriteLine(messageText);
        }
    }
}
