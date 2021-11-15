using StyleCop.Configs;

namespace StyleCop.Services
{
    public class ConfigService
    {
        private readonly CartLengthConfig _cartLength = new CartLengthConfig();
        private readonly UploadLengthConfig _uploadLength = new UploadLengthConfig();

        public int GetCartLimit()
        {
            return _cartLength.GetCartLimit;
        }

        public int GetUploadLimit()
        {
            return _uploadLength.GetUploadLimit;
        }
    }
}
