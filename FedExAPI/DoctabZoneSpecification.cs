namespace FedExAPI
{
    public class DoctabZoneSpecification
    {
        public int? ZoneNumber { get; set; }
        public string? Header { get; set; }
        public string? DataField { get; set; }
        public string? LiteralValue { get; set; }
        public EnumDocTabTextJustification? Justification { get; set; }
    }
}