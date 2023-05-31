using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Charity
    {
        [JsonProperty("CharityType")]
        public long CharityType { get; set; }

        [JsonProperty("ImageSource")]
        public Uri? ImageSource { get; set; }

        [JsonProperty("DarkModeImageSource")]
        public Uri? DarkModeImageSource { get; set; }

        [JsonProperty("Description")]
        public string? Description { get; set; }

        [JsonProperty("Tagline")]
        public string? Tagline { get; set; }
    }
}
