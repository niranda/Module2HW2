using StyleCop.Providers;
using StyleCop.Services;

namespace StyleCop.Main
{
    public class Starter
    {
        private readonly Product[] _availableProducts = new Product[15]
        {
            new Product("IPhone 10", 1568, 1234, Currency.USD),
            new Product("IPhone 9", 1235, 2334, Currency.USD),
            new Product("IPhone 8", 1100, 5435, Currency.USD),
            new Product("IPhone 7", 900, 3454, Currency.USD),
            new Product("IPhone 6", 850, 2545, Currency.USD),
            new Product("IPhone 5", 820, 4643, Currency.USD),
            new Product("IPhone 4", 800, 2554, Currency.USD),
            new Product("IPhone 3", 750, 2355, Currency.USD),
            new Product("IPhone 2", 650, 2346, Currency.USD),
            new Product("IPhone 1", 500, 2446, Currency.USD),
            new Product("IPhone SE", 810, 4689, Currency.USD),
            new Product("IPhone 11+", 2000, 1834, Currency.USD),
            new Product("IPhone 12", 2200, 8986, Currency.USD),
            new Product("IPhone 13", 3000, 8608, Currency.USD),
            new Product("IPhone 14", 4000, 8688, Currency.USD),
        };

        private readonly DeviceService _deviceSercive = new DeviceService();
        private readonly User _user = new User("Nikita", "test@test.com", "033-333-3333");

        public void Run()
        {
            _deviceSercive.UploadDevices(_availableProducts);
            var availableDevices = _deviceSercive.GetDevices();
            _user.AddProductsToCart(availableDevices);
            _user.MakeOrder(_user.UserName, _user.UserEmail, _user.UserPhoneNumber);
        }
    }
}
