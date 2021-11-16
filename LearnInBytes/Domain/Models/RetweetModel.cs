using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RetweetModel
    {
        [JsonPropertyName("tweet_id")]
        public string Tweet_Id { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
    }
}
