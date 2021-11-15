using StyleCop.Providers;

namespace StyleCop.Services
{
    public class CartService
    {
        private static readonly CartService _instance = new CartService();
        private readonly CartProvider _cartProvider = new CartProvider();
        private readonly ConfigService _configuration = new ConfigService();

        static CartService()
        {
        }

        public static CartService Instance => _instance;

        public void AddToCart(Product[] products)
        {
            var necessarryLength = products.Length;
            if (necessarryLength >= _configuration.GetCartLimit())
            {
                necessarryLength = _configuration.GetCartLimit();
            }

            for (var i = 0; i < necessarryLength; i++)
            {
                if (products[i] == null)
                {
                    break;
                }

                _cartProvider.CartProducts[i] = products[i];
            }
        }

        public Product[] GetCartProducts()
        {
            return _cartProvider.CartProducts;
        }
    }
}
