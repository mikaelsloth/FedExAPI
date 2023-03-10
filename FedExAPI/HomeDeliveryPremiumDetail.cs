namespace FedExAPI
{
    public class HomeDeliveryPremiumDetail
    {
        public PhoneNumber? PhoneNumber { get; set; }
        public DateOnly? DeliveryDate { get; set; }
        public EnumHomeDeliveryPremiumType? HomedeliveryPremiumType { get; set; }
    }
}