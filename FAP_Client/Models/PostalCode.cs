using Newtonsoft.Json;

namespace FAP_Client.Models
{
    public class PostalCode
    {
        public string adminCode2 { get; set; }
        public string adminCode3 { get; set; }
        public string adminName3 { get; set; }
        public string adminCode1 { get; set; }
        public string adminName2 { get; set; }
        public double lng { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
        public string adminName1 { get; set; }

        [JsonProperty("ISO3166-2")]
        public string ISO31662 { get; set; }
        public string placeName { get; set; }
        public double lat { get; set; }
    }
}
