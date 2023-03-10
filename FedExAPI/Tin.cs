namespace FedExAPI
{
    public class Tin
    {
        public string? Number { get; set; }
        public EnumTinType? TinType { get; set; }
        public string? Usage { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}