namespace FedExAPI
{
    public class CustomsClearanceDetail
    {
        public List<EnumRegulatoryControlType>? RegulatoryControls { get; set; }
        public List<Broker>? Brokers { get; set; }
        public CommercialInvoice? CommercialInvoice { get; set; }
        public EnumIndiaFreightRiscType? FreightOnValue { get; set; }
        public DutiesPayment? DutiesPayment { get; set; }
        public List<Commodity>? Commodities { get; set; }
        public bool? IsDocumentOnly { get; set; }
        public RecipientCustomsId? RecipientCustomsId { get; set; }
        public CustomsOption? CustomsOption { get; set; }
        public PartyWithTinsAndAccount? ImporterOfRecord { get; set; }
        public EnumLocale? GeneratedDocumentLocale { get; set; }
        public ExportDetail? ExportDetail { get; set; }
        public MonetaryAmount? TotalCustomsValue { get; set; }
        public bool? PartiesToTransactionAreRelated { get; set; }
        public DeclarationStatementDetail? DeclarationStatementDetail { get; set; }
        public MonetaryAmount? InsuranceCharge { get; set; }
    }
}