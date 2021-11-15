namespace StyleCop
{
    public class EmailNotificationService
    {
        private string _emailMessage;

        public bool IsSuccessful(string email, int id)
        {
            // Validation and verification of the email for existence here
            return true;
        }

        public void SendSuccessfulEmail(string email, int id)
        {
            _emailMessage = $"Dear client! Your order with id{id} has been successfully generated!";

            // Email sending process here
        }
    }
}
