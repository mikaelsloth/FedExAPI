namespace FedExAPI
{
    public class ShipmentCodDetail : CodDetailBase
    {
        public AddTransportationChargesDetail? AddTransportationChargesDetail { get; set; }
        public PartyWithTinsAndAccount? CodRecipient { get; set; }
        public string? RemitToName { get; set; }
        public EnumCodCollectionType? CodCollectionType { get; set; }
        public PartyBase? FinancialInstitutionContactAndAddress { get; set; }
        public EnumCodReturnReferenceIndicatorType? ReturnReferenceIndicatorType { get; set; }
        public MonetaryAmount? ShipmentCodAmount { get; set; }
    }
}