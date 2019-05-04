namespace StripeDemo.Models {
    public class ChargesModel {
        public string Token { get; set; }
        public string CurrencyCode { get; set; }
        public long AmountInCents { get; set; }
        public string Description { get; set; }
    }
}
