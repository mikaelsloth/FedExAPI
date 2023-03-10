namespace FedExAPI
{
    public class DutiesPayment : ShippingChargesPayment
    {
        public new DutiesPayor? Payor { get; set; }
        public BillingDetails? BillingDetails { get; set; }
    }
}