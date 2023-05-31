using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    /// <summary>
    /// Class for the Category Object
    /// </summary>
    public class CategoryModel
    {
            [JsonProperty("CategoryId")]
            public long CategoryId { get; set; }

            [JsonProperty("Name")]
            public string? Name { get; set; }

            [JsonProperty("Path")]
            public string? Path { get; set; }

            [JsonProperty("CanListAuctions")]
            public bool CanListAuctions { get; set; }

            [JsonProperty("CanListClassifieds")]
            public bool CanListClassifieds { get; set; }

            [JsonProperty("CanRelist")]
            public bool CanRelist { get; set; }

            [JsonProperty("DefaultDuration")]
            public long DefaultDuration { get; set; }

            [JsonProperty("AllowedDurations")]
            public long[]? AllowedDurations { get; set; }

            [JsonProperty("Fees")]
            public Fees? Fees { get; set; }

            [JsonProperty("FreePhotoCount")]
            public long FreePhotoCount { get; set; }

            [JsonProperty("MaximumPhotoCount")]
            public long MaximumPhotoCount { get; set; }

            [JsonProperty("Charities")]
            public Charity[]? Charities { get; set; }

            [JsonProperty("Promotions")]
            public Promotion[]? Promotions { get; set; }

            [JsonProperty("EmbeddedContentOptions")]
            public object[]? EmbeddedContentOptions { get; set; }

            [JsonProperty("MaximumTitleLength")]
            public long MaximumTitleLength { get; set; }

            [JsonProperty("AreaOfBusiness")]
            public long AreaOfBusiness { get; set; }

            [JsonProperty("DefaultRelistDuration")]
            public long DefaultRelistDuration { get; set; }

            [JsonProperty("CanHaveSecondCategory")]
            public bool CanHaveSecondCategory { get; set; }

            [JsonProperty("CanBeSecondCategory")]
            public bool CanBeSecondCategory { get; set; }

            [JsonProperty("CanUseCounterOffers")]
            public bool CanUseCounterOffers { get; set; }
        } 
}
