namespace StyleCop.Providers
{
    public class Product
    {
        public Product(string name, double price, int id, Currency currency)
        {
            Name = name;
            Price = price;
            Id = id;
            Currency = currency;
        }

        public string Name { get; }
        public double Price { get; }
        public int Id { get; }
        public Currency Currency { get; }
    }
}
