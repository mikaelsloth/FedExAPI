namespace FedExAPI
{
    public class CommercialInvoice
    {
        public string? OriginatorName { get; set; }
        public List<string>? Comments { get; set; }
        public List<CustomerReference>? CustomerReferences { get; set; }
        public MonetaryAmount? TaxesOrMiscellaneousCharge { get; set; }
        public EnumTaxesChargeType? TaxesOrMiscellaneousChargeType { get; set; }
        public MonetaryAmount? FreightCharge { get; set; }
        public MonetaryAmount? PackingCosts { get; set; }
        public MonetaryAmount? HandlingCosts { get; set; }
        public string? DeclarationStatement { get; set; }
        public EnumIncoTerms? TermsOfSale { get; set; }
        public string? SpecialInstructions { get; set; }
        public EnumShipmentPurpose? ShipmentPurpose { get; set; }
        public EmailDispositionDetail? EmailNotificationDetail { get; set; }
    }
}