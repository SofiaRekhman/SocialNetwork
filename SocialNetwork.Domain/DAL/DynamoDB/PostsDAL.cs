using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.DAL.DynamoDB
{
    public class PostsDAL
    {
        static AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
        static AmazonDynamoDBClient client;
        private static string tableName = "SocialNetwork";
        static Table socialNetwork;

        public PostsDAL()
        {
            clientConfig.ServiceURL = "http://localhost:8000";
            client = new AmazonDynamoDBClient(clientConfig);
            socialNetwork = Table.LoadTable(client, tableName);
        }

        public void CreatePostItem(string _id)
        {
            var post = new Document();
            post["PK"] = "POST#<"+_id+">";
            post["SK"] = "POSTt#<" + _id + ">";
            post["PostID"] = "POST#<" + _id + ">";

            socialNetwork.PutItem(post);
        }
    }
}
