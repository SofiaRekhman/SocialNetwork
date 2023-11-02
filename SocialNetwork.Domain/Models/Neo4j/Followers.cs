using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonPropertyAttribute = Newtonsoft.Json.JsonPropertyAttribute;

namespace SocialNetwork.Domain.Models.Neo4j.Followers
{
    public class Followers
    {
        [JsonProperty(PropertyName = "length")]
        public string lenght { get; set; }
    }
}
