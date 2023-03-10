namespace FedExAPI
{
    public class Address
    {
        public List<string>? StreetLines { get; set; }
        public string? City { get; set; }
        public string? StateOrProvinceCode { get; set; }
        public string? PostalCode { get; set; }
        public string? CountryCode { get; set; }
        public bool? Residential { get; set; }
    }
}