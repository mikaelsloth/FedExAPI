namespace FedExAPI
{
    public class Commodity
    {
        public MonetaryAmount? UnitPrice { get; set; }
        public List<AdditionalMeasure>? AdditionalMeasures { get; set; }
        public int? NumberOfPieces { get; set; }
        public int? Quantity { get; set; }
        public EnumUnit? QuantityUnits { get; set; }
        public MonetaryAmount? CustomsValue { get; set; }
        public string? CountryOfManufacture { get; set; }
        public string? CIMarksAndNumbers { get; set; }
        public string? HarmonizedCode { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public Weight? Weight { get; set; }
        public string? ExportLicenseNumber { get; set; }
        public DateOnly? ExportLicenseExpirationDate { get; set; }
        public string? PartNumber { get; set; }
        public EnumPurposeType? Purpose { get; set; }
        public UsmcaDetail? UsmcaDetail { get; set; }
    }
}