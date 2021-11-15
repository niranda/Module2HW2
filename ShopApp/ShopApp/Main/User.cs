using StyleCop.Providers;
using StyleCop.Services;

namespace StyleCop.Main
{
    public class User
    {
        private readonly CartService _cart = CartService.Instance;
        private readonly OrderService _order = OrderService.Instance;

        public User(string userName, string userEmail, string userPhoneNumber)
        {
            UserName = userName;
            UserEmail = userEmail;
            UserPhoneNumber = userPhoneNumber;
        }

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public void AddProductsToCart(Product[] products)
        {
            _cart.AddToCart(products);
        }

        public void MakeOrder(string name, string email, string phoneNumber)
        {
            var products = _cart.GetCartProducts();
            _order.MakeOrder(name, email, phoneNumber, products);
        }
    }
}
