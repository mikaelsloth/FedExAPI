namespace FedExAPI
{
    public class LabelSpecification
    {
        public EnumLabelFormatType? LabelFormatType { get; set; }
        public LabelOrderOption? LabelOrder { get; set; }
        public CustomerSpecifiedDetail? CustomerSpecifiedDetail { get; set; }
        public PartyBase? PrintedLabelOrigin { get; set; }
        public EnumLabelStockType? LabelStockType { get; set; }
        public EnumLabelRotation? LabelRotation { get; set; }
        public EnumLabelImageType? ImageType { get; set; }
        public EnumLabelPrintingOrientation? LabelPrintingOrientation { get; set; }
        public bool? ReturnedDispositionDetail { get; set; }
    }
}