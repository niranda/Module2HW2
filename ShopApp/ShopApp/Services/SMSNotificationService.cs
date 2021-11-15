namespace StyleCop
{
    public class SMSNotificationService
    {
        private string _smsMessage;

        public bool IsSuccess(string number, int id)
        {
            // Validation and verification of the number for existence here
            return true;
        }

        public void SendSuccessfulSMS(string phoneNumber, int id)
        {
            _smsMessage = $"Dear client! Your order with id{id} has been successfully generated!";

            // SMS sending process here
        }
    }
}
