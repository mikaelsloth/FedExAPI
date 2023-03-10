namespace FedExAPI
{
    public class HoldAtLocationDetail
    {
        public string? LocationId { get; set; }
        public PartyBase? LocationContactAndAddress { get; set; }
        public EnumLocationType? LocationType { get; set; }
    }
}