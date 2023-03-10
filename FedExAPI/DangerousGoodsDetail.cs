namespace FedExAPI
{
    public class DangerousGoodsDetail
    {
        public bool? CargoAircraftOnly { get; set; }
        public EnumDangerousGoodsAccessibility? Accessibility { get; set; }
        public List<EnumDgOption>? Options { get; set; }
    }
}