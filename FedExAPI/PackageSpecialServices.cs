namespace FedExAPI
{
    public class PackageSpecialServices
    {
        public List<EnumPackageSpecialServiceType>? SpecialServiceTypes { get; set; }
        public EnumSignatureOptionType? SignatureOptionType { get; set; }
        public PriorityAlertDetail? PriorityAlertDetail { get; set; }
        public SignatureOptionDetail? SignatureOptionDetail { get; set; }
        public AlcoholDetail? AlcoholDetail { get; set; }
        public DangerousGoodsDetail? DangerousGoodsDetail { get; set; }
        public CodDetailBase? PackageCODDetail { get; set; }
        public int? PieceCountVerificationBoxCount { get; set; }
        public List<BatteryDetail>? BatteryDetails { get; set; }
        public Weight? DryIceWeight { get; set; }
    }
}