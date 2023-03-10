namespace FedExAPI
{
    public class RequestedPackageLineItem
    {
        public int? SequenceNumber { get; set; }
        public EnumSubPackagingType? SubPackagingType { get; set; }
        public List<CustomerReference>? CustomerReferences { get; set; }
        public MonetaryAmount? DeclaredValue { get; set; }
        public Weight? Weight { get; set; }
        public Dimensions? Dimensions { get; set; }
        public int? GroupPackageCount { get; set; }
        public string? ItemDescriptionForClearance { get; set; }
        public List<ContentRecord>? ContentRecord { get; set; }
        public string? ItemDescription { get; set; }
        public VariableHandlingChargeDetail? VariableHandlingChargeDetail { get; set; }
        public PackageSpecialServices? PackageSpecialServices { get; set; }
        public string? TrackingNumber { get; set; }
    }
}