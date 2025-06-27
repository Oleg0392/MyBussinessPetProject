namespace MyBussinessWeb.Models
{
    public class Payment(string cardName, string cardNumber, string expiration, string cvv, int paymentMethod)
    {
        public readonly string CardName = cardName;
        public readonly string CardNumber = cardNumber;
        public readonly string Expiration = expiration;
        public readonly string Cvv = cvv;
        public readonly int PaymentMethod = paymentMethod;
    }
}
