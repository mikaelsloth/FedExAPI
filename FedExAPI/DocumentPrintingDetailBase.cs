namespace FedExAPI
{
    public class DocumentPrintingDetailBase
    {
        public List<CustomerImageUsage>? CustomerImageUsages { get; set; }
        public DocumentFormat? DocumentFormat { get; set; }
    }
}