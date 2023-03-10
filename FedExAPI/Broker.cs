namespace FedExAPI
{
    using System.Text.Json.Serialization;

    public class Broker
    {
        [JsonPropertyName("broker")]
        public PartyWithTinsAndAccount? BrokerAddress { get; set; }
        public EnumBrokerType? Type { get; set; }
    }
}