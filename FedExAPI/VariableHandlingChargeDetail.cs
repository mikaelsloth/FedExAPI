namespace FedExAPI
{
    public class VariableHandlingChargeDetail
    {
        public EnumHandlingChargeRateType? RateType { get; set; }
        public double? PercentValue { get; set; }
        public EnumRateLevelType? RateLevelType { get; set; }
        public MonetaryAmount? FixedValue { get; set; }
        public EnumHandlingChargeType? RateElementBasis { get; set; }
    }
}