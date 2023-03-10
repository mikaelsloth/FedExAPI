namespace FedExAPI
{
    public class ShippingDocumentSpecification
    {
        public GeneralAgencyAgreementDetail? GeneralAgencyAgreementDetail { get; set; }
        public ReturnInstructionsDetail? ReturnInstructionsDetail { get; set; }
        public Op900Detail? Op900Detail { get; set; }
        public UsmcaCertificationOfOriginDetail? UsmcaCertificationOfOriginDetail { get; set; }
        public UsmcaCertificationOfOrigin? UsmcaCommercialInvoiceCertificationOfOriginDetail { get; set; }
        public List<EnumShippingDocumentType>? ShippingDocumentTypes { get; set; }
        public DocumentPrintingDetailBase? CertificateOfOrigin { get; set; }
        public DocumentPrintingDetailBase? CommercialInvoiceDetail { get; set; }
    }
}