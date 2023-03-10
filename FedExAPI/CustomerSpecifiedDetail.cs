namespace FedExAPI
{
    public class CustomerSpecifiedDetail
    {
        public List<EnumMaskedDataType>? MaskedData { get; set; }
        public List<RegulatoryLabel>? RegulatoryLabels { get; set; }
        public List<AdditionalLabel>? AdditionalLabels { get; set; }
        public DoctabContent? DocTabContent { get; set; }
    }
}