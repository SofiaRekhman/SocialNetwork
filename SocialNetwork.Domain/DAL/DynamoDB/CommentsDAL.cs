using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = Amazon.DynamoDBv2.DocumentModel.Document;

namespace SocialNetwork.Domain.DAL.DynamoDB
{
    public class CommentsDAL
    {
        static AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
        static AmazonDynamoDBClient client;
        private static string tableName = "SocialNetwork";
        static Table socialNetwork;
        private static string indexName = "SortedIndex";
        static GlobalSecondaryIndex sortedIndex;

        public CommentsDAL()
        {
            clientConfig.ServiceURL = "http://localhost:8000";
            client = new AmazonDynamoDBClient(clientConfig);
            socialNetwork = Table.LoadTable(client, tableName);
        }

        public void CreateCommentItem(string postId, string commentId, string userId, string username, string commentText)
        {
            var comment = new Document();
            comment["PK"] = "POST#<" + postId + ">";
            comment["SK"] = "COMMENT#<" + commentId + ">";
            comment["PostID"] = postId;
            comment["CommentID"] = commentId;
            comment["UserID"] = userId;
            comment["Username"] = username;
            comment["CommentText"] = commentText;
            comment["ModifiedDateTime"] = DateTime.Now;
            comment["IsDeleted"] = false;

            socialNetwork.PutItem(comment);
        }

        public void DeleteCommentItem(string postId, string commentId)
        {
            var comment = new Document();
            comment["PK"] = "POST#<" + postId + ">";
            comment["SK"] = "COMMENT#<" + commentId + ">";
            comment["ModifiedDateTime"] = DateTime.Now;
            comment["IsDeleted"] = true;
            socialNetwork.UpdateItem(comment);
        }

        public void UpdateCommentItem(string postId, string commentId, string commentText)
        {
            var comment = new Document();
            comment["PK"] = "POST#<" + postId + ">";
            comment["SK"] = "COMMENT#<" + commentId + ">";
            comment["CommentText"] = commentText;
            comment["ModifiedDateTime"] = DateTime.Now;
            socialNetwork.UpdateItem(comment);
        }

        public List<Document> QueryTable(string postId)
        {
            QueryFilter filter = new QueryFilter("PK", QueryOperator.Equal, postId);
            filter.AddCondition("SK", QueryOperator.BeginsWith, "COMMENT#");
            Search search = socialNetwork.Query(filter);

            List<Document> documentSet = new List<Document>();
            do
            {
                documentSet = search.GetNextSet();
            } while (!search.IsDone);

            return documentSet;
        }

        public List<Document> QueryIndex(string postId)
        {
            QueryRequest queryRequest = new QueryRequest
            {
                TableName = tableName,
                IndexName = indexName,
                ScanIndexForward = false
            };


            String keyConditionExpression = "PK = :id and begind_with(ModifiedDateTimeSK, :comm";
            Dictionary<string, AttributeValue> expressionAttributeValues = new Dictionary<string, AttributeValue>();
            expressionAttributeValues.Add(":id", new AttributeValue
            {
                S = postId
            });
            expressionAttributeValues.Add(":comm", new AttributeValue
            {
                S = "COMMENT#"
            });

            queryRequest.Select = "ALL_PROJECTED_ATTRIBUTES";

            queryRequest.KeyConditionExpression = keyConditionExpression;
            queryRequest.ExpressionAttributeValues = expressionAttributeValues;

            var items = client.Query(queryRequest).Items;
            List<Document> documentSet = new List<Document>();
            foreach (var currentItem in items)
            {
                var doc = new Document();
                foreach (string attr in currentItem.Keys)
                {
                    if (attr == "IsDeleted")
                    {
                        doc[attr] = currentItem[attr].BOOL;
                    }
                    else
                    {
                        doc[attr] = currentItem[attr].S;
                    }

                }
            }
            return documentSet;
        }

        private void CreateIndex()
        {
            sortedIndex = new GlobalSecondaryIndex()
            {
                IndexName = "SortedIndex",
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 1L,
                    WriteCapacityUnits = 1L
                },
                KeySchema = {
                new KeySchemaElement {
                    AttributeName = "PK", KeyType = "HASH"
                },
                new KeySchemaElement {
                    AttributeName = "ModifiedDateTimeSK", KeyType = "RANGE"
                }
                },
                Projection = new Projection
                {
                    ProjectionType = "ALL"
                }
            };
        }


    }
}
