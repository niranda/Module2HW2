using System;

namespace StyleCop
{
    public class ConsoleNotificationService
    {
        public void SuccessMessage(string name, string email, string phoneNumber, int id)
        {
            Console.WriteLine($"Dear {name}, your order with id{id} has been successfully generated!");
            Console.WriteLine("Delivery will arrive in 2 business days.");
            Console.WriteLine($"An SMS was also successfully generated and sent to the number {phoneNumber}");
            Console.WriteLine($"It's the same with email {email}");
        }

        public void InvalidMessage(string name)
        {
            Console.WriteLine($"Dear {name}, either your email or phone number is incorrect.");
            Console.WriteLine("Please check it once again and repeat the order");
        }

        public void ErrorMessage(string name)
        {
            Console.WriteLine($"Dear {name}, unfortunately something went wrong :(");
            Console.WriteLine("Try again to make the order. If it doesn't work, do inform us about any misunderstandings");
        }
    }
}
