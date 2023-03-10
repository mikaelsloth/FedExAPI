namespace FedExAPI
{
    public class CreateShipmentRootobject
    {
        public EnumMergeLabelDocOption? MergeLabelDocOption { get; set; }
        public RequestedShipment? RequestedShipment { get; set; }
        public EnumLabelResponseOptions? LabelResponseOptions { get; set; }
        public AccountNumber? AccountNumber { get; set; }
        public EnumShipAction? ShipAction { get; set; }
        public EnumProcessingOptionType? ProcessingOptionType { get; set; }
        public bool? OneLabelAtATime { get; set; }
    }
}