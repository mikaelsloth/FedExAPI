namespace FedExAPI
{
    public class PendingShipmentDetail
    {
        public EnumPendingShipmentType? PendingShipmentType { get; set; }
        public ProcessingOptions? ProcessingOptions { get; set; }
        public RecommendedDocumentSpecification? RecommendedDocumentSpecification { get; set; }
        public EmailLabelDetail? EmailLabelDetail { get; set; }
        public List<AttachedDocument>? AttachedDocuments { get; set; }
        public DateOnly? ExpirationTimeStamp { get; set; }
    }
}