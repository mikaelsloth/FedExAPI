namespace FedExAPI
{
    public class ExportDetail
    {
        public DestinationControlDetail? DestinationControlDetail { get; set; }
        public EnumB13AFilingOption? B13AFilingOption { get; set; }
        public string? ExportComplianceStatement { get; set; }
        public string? PermitNumber { get; set; }
    }
}