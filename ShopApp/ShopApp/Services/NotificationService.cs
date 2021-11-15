namespace StyleCop
{
    public class NotificationService
    {
        private readonly SMSNotificationService _smsNotification = new SMSNotificationService();
        private readonly EmailNotificationService _emailNotification = new EmailNotificationService();
        private readonly ConsoleNotificationService _consoleNotification = new ConsoleNotificationService();

        public void NotifySuccess(int id, string name, string email, string phoneNumber)
        {
            if (_smsNotification.IsSuccess(phoneNumber, id) && _emailNotification.IsSuccessful(email, id))
            {
                _smsNotification.SendSuccessfulSMS(phoneNumber, id);
                _emailNotification.SendSuccessfulEmail(email, id);
                _consoleNotification.SuccessMessage(name, email, phoneNumber, id);
            }
            else
            {
                _consoleNotification.InvalidMessage(name);
            }
        }

        public void NotifyError(string name)
        {
            _consoleNotification.ErrorMessage(name);
        }
    }
}
