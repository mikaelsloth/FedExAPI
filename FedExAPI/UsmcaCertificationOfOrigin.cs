namespace FedExAPI
{
    public class UsmcaCertificationOfOrigin : DocumentPrintingDetailBase
    {
        public string? CertifierJobTitle { get; set; }
        public EnumUsmcaCertifier? CertifierSpecification { get; set; }
        public EnumUsmcaImporter? ImporterSpecification { get; set; }
        public PartyWithTins? Producer { get; set; }
        public EnumUsmcaProducer? ProducerSpecification { get; set; }
    }
}