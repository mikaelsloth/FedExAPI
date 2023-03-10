namespace FedExAPI
{
    public class ShipmentSpecialServices
    {
        public List<EnumShipmentSpecialServiceType>? SpecialServiceTypes { get; set; }
        public EtdDetail? EtdDetail { get; set; }
        public ReturnShipmentDetail? ReturnShipmentDetail { get; set; }
        public DeliveryOnInvoiceAcceptanceDetail? DeliveryOnInvoiceAcceptanceDetail { get; set; }
        public InternationalTrafficInArmsRegulationsDetail? InternationalTrafficInArmsRegulationsDetail { get; set; }
        public PendingShipmentDetail? PendingShipmentDetail { get; set; }
        public HoldAtLocationDetail? HoldAtLocationDetail { get; set; }
        public ShipmentCodDetail? ShipmentCODDetail { get; set; }
        public ShipmentDryIceDetail? ShipmentDryIceDetail { get; set; }
        public InternationalControlledExportDetail? InternationalControlledExportDetail { get; set; }
        public HomeDeliveryPremiumDetail? HomeDeliveryPremiumDetail { get; set; }
    }
}