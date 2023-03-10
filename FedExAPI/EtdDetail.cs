namespace FedExAPI
{
    public class EtdDetail
    {
        public List<EnumEtdAttribute>? Attributes { get; set; }
        public List<AttachedDocument>? AttachedDocuments { get; set; }
        public List<EnumRequestedDocumentType>? RequestedDocumentTypes { get; set; }
    }
}