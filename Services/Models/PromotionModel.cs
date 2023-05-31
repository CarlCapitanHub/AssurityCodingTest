using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Promotion
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Name")]
        public string? Name { get; set; }

        [JsonProperty("Description")]
        public string? Description { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("MinimumPhotoCount")]
        public long MinimumPhotoCount { get; set; }

        [JsonProperty("OriginalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? OriginalPrice { get; set; }

        [JsonProperty("GoodFor2RelistsFee", NullValueHandling = NullValueHandling.Ignore)]
        public double? GoodFor2RelistsFee { get; set; }

        [JsonProperty("Recommended", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recommended { get; set; }
    }
}
