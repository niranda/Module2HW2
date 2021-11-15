using StyleCop.Configs;
using StyleCop.Services;

namespace StyleCop.Providers
{
    public class CartProvider
    {
        private readonly ConfigService _configuration = new ConfigService();
        public CartProvider()
        {
            var cartLimit = _configuration.GetCartLimit();
            CartProducts = new Product[cartLimit];
        }

        public Product[] CartProducts { get; set; }
    }
}
