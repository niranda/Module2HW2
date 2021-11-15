using StyleCop.Providers;

namespace StyleCop.Services
{
    public class DeviceService
    {
        private readonly DeviceProvider _deviceProvider = new DeviceProvider();
        private readonly ConfigService _configuration = new ConfigService();

        public void UploadDevices(Product[] inputData)
        {
            var necessarryLength = inputData.Length;
            if (necessarryLength >= _configuration.GetUploadLimit())
            {
                necessarryLength = _configuration.GetUploadLimit();
            }

            for (var i = 0; i < necessarryLength; i++)
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
