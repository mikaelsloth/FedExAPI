namespace FedExAPI
{
    public class DestinationControlDetail
    {
        public string? EndUser { get; set; }
        public EnumStatementType? StatementTypes { get; set; }
        public List<string>? DestinationCountries { get; set; }
    }
}