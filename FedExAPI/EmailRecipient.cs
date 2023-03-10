namespace FedExAPI
{
    public class EmailRecipient : EmailRecipientBase
    {
        public OptionsRequested? OptionsRequested { get; set; }
        public EnumEmailRecipientRole? Role { get; set; }
        public EnumLocale? Locale { get; set; }
    }
}