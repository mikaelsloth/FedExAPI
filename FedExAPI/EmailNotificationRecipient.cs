namespace FedExAPI
{
    public class EmailNotificationRecipient
    {
        public string? Name { get; set; }
        public EnumEmailNotificationRecipientType? EmailNotificationRecipientType { get; set; }
        public string? EmailAddress { get; set; }
        public EnumNotificationFormatType? NotificationFormatType { get; set; }
        public EnumNotificationType? NotificationType { get; set; }
        public EnumLocale? Locale { get; set; }
        public List<EnumEventType>? NotificationEventType { get; set; }
    }
}