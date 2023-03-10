namespace FedExAPI
{
    public class EmailDetail
    {
        public List<EmailDocumentRecipient>? EMailRecipients { get; set; }
        public EnumLocale? Locale { get; set; }
        public EnumEmailDocumentGrouping? Grouping { get; set; }
    }
}