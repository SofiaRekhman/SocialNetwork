using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.DAL.DynamoDB
{
    public class ReactionsDAL
    {
        static AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
        static AmazonDynamoDBClient client;
        private static string tableName = "SocialNetwork";
        static Table socialNetwork;

        public ReactionsDAL()
        {
            clientConfig.ServiceURL = "http://localhost:8000";
            client = new AmazonDynamoDBClient(clientConfig);
            socialNetwork = Table.LoadTable(client, tableName);
        }

        public void CreateReactionItem(string postId, string commentId, string userId, string username)
        {
            var reaction = new Document();
            reaction["PK"] = "POST#<" + postId + ">";
            reaction["SK"] = "REACTION#COMMENT#<" + commentId + ">#USER<"+userId+">";
            reaction["CommentID"] = commentId;
            reaction["UserID"] = userId;
            reaction["Username"] = username;

            socialNetwork.PutItem(reaction);
        }

        public void DeleteReactionItem(string postId, string commentId, string userId)
        {
            socialNetwork.DeleteItem("POST#<" + postId + ">", "REACTION#COMMENT#<" + commentId + ">#USER<" + userId + ">");
        }
    }
}
