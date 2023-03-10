namespace FedExAPI
{
    public class EmailDispositionDetail
    {
        public string? EmailAddress { get; set; }
        public string? Type { get; set; } 
        public EnumRecipientType? RecipientType { get; set; }
    }
}