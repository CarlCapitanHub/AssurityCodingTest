using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class SuccessFeeTier
    {
        [JsonProperty("MinimumTierPrice")]
        public long MinimumTierPrice { get; set; }

        [JsonProperty("PercentageFee", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageFee { get; set; }
    }
}
