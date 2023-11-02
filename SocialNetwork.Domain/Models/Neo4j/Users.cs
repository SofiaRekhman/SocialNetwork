using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;
using Newtonsoft.Json;
using Nest;
using JsonPropertyAttribute = Newtonsoft.Json.JsonPropertyAttribute;

namespace SocialNetwork.Domain.Models.Neo4j.Users
{
    public class UsersNeo4j
    {
        [JsonProperty(PropertyName = "UserID")]
        public int User_Id { get; set; }
        [JsonProperty(PropertyName = "UserName")]
        public string User_Login { get; set; }
        [JsonProperty(PropertyName = "UserEmail")]
        public string User_Email { get; set; }

        [JsonProperty(PropertyName = "FisrtName")]
        public string User_Name { get; set; }

        [JsonProperty(PropertyName = "SurName")]
        public string User_Surname { get; set; }
    }
}
