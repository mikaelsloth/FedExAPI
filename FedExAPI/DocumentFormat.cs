namespace FedExAPI
{
    public class DocumentFormat
    {
        public bool? ProvideInstructions { get; set; }
        public LabelOrder? OptionsRequested { get; set; }
        public EnumLabelStockType? StockType { get; set; }
        public List<Disposition>? Dispositions { get; set; }
        public EnumLocale? Locale { get; set; }
        public EnumLabelImageType? DocType { get; set; }
    }
}