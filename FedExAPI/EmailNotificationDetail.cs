namespace FedExAPI
{
    public class EmailNotificationDetail
    {
        public EnumNotificationAggregationType? AggregationType { get; set; }
        public List<EmailNotificationRecipient>? EmailNotificationRecipients { get; set; }
        public string? PersonalMessage { get; set; }
    }
}