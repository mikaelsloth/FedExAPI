namespace FedExAPI
{
    public class RequestedShipment
    {
        public DateOnly? ShipDatestamp { get; set; }
        public MonetaryAmount? TotalDeclaredValue { get; set; }
        public PartyWithTins? Shipper { get; set; }
        public PartyWithTinsAndAccount? SoldTo { get; set; }
        public List<Recipient>? Recipients { get; set; } 
        public string? RecipientLocationNumber { get; set; }
        public EnumPickupType? PickupType { get; set; }
        public string? ServiceType { get; set; }
        public EnumPackagingType? PackagingType { get; set; }
        public double? TotalWeight { get; set; }
        public PartyBase? Origin { get; set; }
        public ShippingChargesPayment? ShippingChargesPayment { get; set; }
        public ShipmentSpecialServices? ShipmentSpecialServices { get; set; }
        public EmailNotificationDetail? EmailNotificationDetail { get; set; }
        public ExpressFreightDetail? ExpressFreightDetail { get; set; }
        public VariableHandlingChargeDetail? VariableHandlingChargeDetail { get; set; }
        public CustomsClearanceDetail? CustomsClearanceDetail { get; set; }
        public SmartpostInfoDetail? SmartPostInfoDetail { get; set; }
        public bool? BlockInsightVisibility { get; set; }
        public LabelSpecification? LabelSpecification { get; set; }
        public ShippingDocumentSpecification? ShippingDocumentSpecification { get; set; }
        public List<EnumRateRequestType>? RateRequestType { get; set; }
        public string? PreferredCurrency { get; set; }
        public int? TotalPackageCount { get; set; }
        public MasterTrackingId? MasterTrackingId { get; set; }
        public List<RequestedPackageLineItem>? RequestedPackageLineItems { get; set; }
    }
}