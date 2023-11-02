using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SocialNetwork.Models
{
    public class Posts
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("userId")]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string UserIdPost { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedTime { get; set; }

        [BsonElement("comments")]
        public List<string> Comments { get; set; }

        [BsonElement("reactions")]
        public List<string> Reactions { get; set; }

        
    }
}
