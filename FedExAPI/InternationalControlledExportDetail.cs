namespace FedExAPI
{
    public class InternationalControlledExportDetail
    {
        public DateOnly? LicenseOrPermitExpirationDate { get; set; }
        public string? LicenseOrPermitNumber { get; set; }
        public string? EntryNumber { get; set; }
        public string? ForeignTradeZoneCode { get; set; }
        public EnumInternationalControlledExportType? Type { get; set; }
    }
}