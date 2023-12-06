using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Models.Redis
{
    public class Users
    {
        public string Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Users FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Users>(json);
        }
    }
}
