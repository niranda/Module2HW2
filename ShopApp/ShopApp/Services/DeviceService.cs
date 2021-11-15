using StyleCop.Providers;

namespace StyleCop.Services
{
    public class DeviceService
    {
        private readonly DeviceProvider _deviceProvider = new DeviceProvider();
        private readonly ConfigService _configuration = new ConfigService();

        public void UploadDevices(Product[] inputData)
        {
            for (var i = 0; i < _configuration.GetUploadLimit(); i++)
            {
                if (inputData[i] == null)
                {
                    break;
                }

                _deviceProvider.AvailableProducts[i] = inputData[i];
            }
        }

        public Product[] GetDevices()
        {
            return _deviceProvider.AvailableProducts;
        }
    }
}
