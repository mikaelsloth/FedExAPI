namespace FedExAPI
{
    public class AttachedDocument
    {
        public EnumDocumentType? DocumentType { get; set; }
        public string? DocumentReference { get; set; }
        public string? Description { get; set; }
        public string? DocumentId { get; set; }
    }
}