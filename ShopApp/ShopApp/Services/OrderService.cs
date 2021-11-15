using StyleCop.Providers;

namespace StyleCop.Services
{
    public class OrderService
    {
        private static readonly OrderService _instance = new OrderService();
        private readonly IdService _idGenerator = new IdService();
        private readonly NotificationService _notification = new NotificationService();

        static OrderService()
        {
        }

        public static OrderService Instance => _instance;

        public void MakeOrder(string name, string email, string phoneNumber, Product[] products)
        {
            var status = GetStatus();
            if (status)
            {
                var id = _idGenerator.IdNumber;

                _notification.NotifySuccess(id, name, email, phoneNumber);
            }
            else
            {
                _notification.NotifyError(name);
            }
        }

        public bool GetStatus()
        {
            // Some server checks here
            return true;
        }
    }
}
