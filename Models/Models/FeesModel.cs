using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Fees
    {
        [JsonProperty("Bundle")]
        public double Bundle { get; set; }

        [JsonProperty("EndDate")]
        public double EndDate { get; set; }

        [JsonProperty("Feature")]
        public double Feature { get; set; }

        [JsonProperty("Gallery")]
        public double Gallery { get; set; }

        [JsonProperty("Reserve")]
        public double Reserve { get; set; }

        [JsonProperty("Subtitle")]
        public double Subtitle { get; set; }

        [JsonProperty("TenDays")]
        public double TenDays { get; set; }

        [JsonProperty("Withdrawal")]
        public double Withdrawal { get; set; }

        [JsonProperty("HighVolume")]
        public double HighVolume { get; set; }

        [JsonProperty("MaximumSuccessFee")]
        public double MaximumSuccessFee { get; set; }

        [JsonProperty("SuccessFeeTiers")]
        public SuccessFeeTier[]? SuccessFeeTiers { get; set; }

        [JsonProperty("SecondCategory")]
        public double SecondCategory { get; set; }
    }
}
