using StyleCop.Services;

namespace StyleCop.Providers
{
    public class DeviceProvider
    {
        private readonly ConfigService _configuration = new ConfigService();

        public DeviceProvider()
        {
            var uploadLimit = _configuration.GetUploadLimit();
            AvailableProducts = new Product[uploadLimit];
        }

        public Product[] AvailableProducts { get; set; }
    }
}
