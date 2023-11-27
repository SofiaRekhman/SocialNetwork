using MongoDB.Driver;
using SocialNetwork.DAL;
using SocialNetwork.Domain.DAL.Neo4j.UsersDAL;
using SocialNetwork.Models;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using SocialNetwork.Domain.Models.Neo4j.Users;
using SocialNetwork.Domain.DAL;
using System.Security.Cryptography;
using SocialNetwork.Domain.DAL.DynamoDB;
using Amazon.DynamoDBv2.DocumentModel;

namespace SocialNetwork.Domain.BLL.Commands
{
    public class Commands
    {
        static public void AddFriend(string userId, string friendId)
        {
            UsersDAL.NewFollowUser(userId, friendId);
            UsersDALNeo4j.CreateFriendConnection(userId, friendId);
        }

        static public void DeleteFriend(string userId, string friendId)
        {
            UsersDAL.DeleteFriend(userId, friendId);
            UsersDALNeo4j.DeleteFriendConnection(userId, friendId);
        }

        static public Tuple<bool, int, List<Posts>> OnSelectionChanged(string userId, string getId)
        {
            return Tuple.Create(UsersDALNeo4j.CheckFriendConnection(userId, getId),
                UsersDALNeo4j.PathLength(userId, getId), SocialNetwork.Domain.DAL.PostsDAL.GetUserPosts(getId));
        }

        static public void AddPost(string currentId, string context)
        {
            var newPostId = SocialNetwork.Domain.DAL.PostsDAL.AddingPost(currentId, context);
            var postDynamoDAL = new SocialNetwork.Domain.DAL.DynamoDB.PostsDAL();
            postDynamoDAL.CreatePostItem(newPostId);
        }
        static public void CreateReactionComment(string currentId, string commentId, string friendId, string reactionType)
        {
            SocialNetwork.Domain.DAL.PostsDAL.UpdateReaction(reactionType, commentId);
            var reactionDynamoDAL = new ReactionsDAL();
            reactionDynamoDAL.CreateReactionItem(SocialNetwork.Domain.DAL.PostsDAL.GetPostsIdsByUserId(currentId), commentId, currentId, friendId);
        }

        static public void AddComment(string currentId, string postId, string context, string friendId)
        {
            string _id = SocialNetwork.Domain.DAL.PostsDAL.AddComment(postId, context);
            var commentDynamoDAL = new CommentsDAL();
            commentDynamoDAL.CreateCommentItem(postId, _id, currentId, friendId, context);
        }

        static public void UpdateComment(string postId, string commentId, string text)
        {
            var commentDynamoDAL = new CommentsDAL();
            commentDynamoDAL.UpdateCommentItem(postId, commentId, text);
        }

        static List<Document> GetPostComments(string postId)
        {
            var commentDynamoDAL = new CommentsDAL();
            return commentDynamoDAL.QueryIndex(postId);
        }
    }
}
