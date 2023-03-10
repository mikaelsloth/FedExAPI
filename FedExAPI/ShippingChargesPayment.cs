namespace FedExAPI
{
    public class ShippingChargesPayment
    {
        public EnumPaymentType? PaymentType { get; set; }
        public Payor? Payor { get; set; }
    }
}