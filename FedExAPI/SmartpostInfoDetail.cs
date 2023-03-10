namespace FedExAPI
{
    public class SmartpostInfoDetail
    {
        public EnumAncillaryEndorsementType? AncillaryEndorsement { get; set; }
        public string? HubId { get; set; }
        public EnumIndiciaType? Indicia { get; set; }
        public EnumSmartPostSpecialService? SpecialServices { get; set; }
    }
}