using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Domain.DAL
{
    public class PostsDAL
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase database = client.GetDatabase("Test");
        static IMongoCollection<Posts> posts = database.GetCollection<Posts>("Posts");

        public static List<Posts> GetSortedPosts()
        {
            return posts.Aggregate().SortByDescending(x => x.CreatedTime).ToList();
        }

        public static Posts GetPostById(string postId)
        {
            return posts.Find(y => y.Id == postId).FirstOrDefault();
        }

        public static List<Posts> GetUserPosts(string userId)
        {
            return posts.Find(y => y.UserIdPost == userId).ToList();
        }

        public static List<string> GetPostsIdsByUserId (string userId)
        {
            var filter = Builders<Posts>.Filter.Eq(p => p.UserIdPost, userId);
            var projection = Builders<Posts>.Projection.Include(p => p.Id);

            var postIds = posts.Find(filter).Project(projection).ToList();
            
            List<string> postIdsAsString = postIds.Select(p => p.GetValue("_id").ToString()).ToList();

            return postIdsAsString;
        }


        public static int GetUserPostsCount(string userId)
        {
            var usersPosts = GetUserPosts(userId).ToArray();
            var count = usersPosts.Count();
            return count;
        }

        public static string AddComment(string postId, string comment)
        {
            var filter = Builders<Posts>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Posts>.Update.Push(y => y.Comments, comment);
            posts.FindOneAndUpdate(filter, update);
            return comment;
        }

        public static void AddPost(string userId, string content, List<string> comment)
        {
            var newPostId = ObjectId.GenerateNewId();
            var newPost = new Posts
            {
                Id = newPostId.ToString(),
                UserIdPost = userId,
                Content = content,
                CreatedTime = DateTime.Now,
                Comments = comment,
                Reactions = { }
            };
            posts.InsertOne(newPost);
        }
        public static string AddingPost(string userId, string context)
        {
            Posts newPost = new Posts();
            newPost.Content = context;
            newPost.CreatedTime = DateTime.Now;
            newPost.UserIdPost = userId;
            newPost.Reactions = new List<string>() { };
            newPost.Comments = new List<string>() { };  
            var task = posts.InsertOneAsync(newPost);
            task.Wait();
            return Convert.ToString(newPost.Id);
        }
        public static void UpdateReaction(string reactionType, string postId)
        {
            var filter = Builders<Posts>.Filter.Eq("_id", postId);

            var post = posts.Find(filter).FirstOrDefault();

            if (post != null)
            {
                var reactions = post.Reactions;
                if (reactions.Contains(reactionType))
                {
                    var reactArr = reactions.FirstMatchingElement().ToArray();
                    var count = reactArr.Length;
                    count++;
                }
                else
                {
                    reactions.Add(reactionType);
                }


                var update = Builders<Posts>.Update.Set(p => p.Reactions, reactions);
                posts.UpdateOne(filter, update);
            }
        }
       
    }
}
