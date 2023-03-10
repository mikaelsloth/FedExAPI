namespace FedExAPI
{
    public class AddTransportationChargesDetail
    {
        public EnumRateType? RateType { get; set; }
        public EnumRateLevelType? RateLevelType { get; set; }
        public EnumChargeLevelType? ChargeLevelType { get; set; }
        public EnumCodChargeType? ChargeType { get; set; }
    }
}