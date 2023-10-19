using MongoDB.Driver;
using SocialNetwork.Models;


namespace SocialNetwork.DAL
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

        public static string AddComment(string postId, string comment)
        {
            var filter = Builders<Posts>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Posts>.Update.Push(y => y.Comments, comment);
            posts.FindOneAndUpdate(filter, update);
            return comment;
        }

        public static string AddPost(Posts post)
        {
            posts.InsertOneAsync(post).Wait();
            return post.Id;
        }

        public static void LikePost(string postId, string userIdCurrent)
        {
            var likesUsersArray = posts.Find(x => x.Id == postId).Project("{likesUsersPost:1}").FirstOrDefault().GetValue("likesUsersPost").AsBsonArray;

            bool likesIncDec;
            if (likesUsersArray.Contains(userIdCurrent))
            {
                likesUsersArray.Remove(userIdCurrent);
                likesIncDec = false;
            }
            else
            {
                likesUsersArray.Add(userIdCurrent);
                likesIncDec = true;
            }

            var filter = Builders<Posts>.Filter.Eq(x => x.Id, postId);
            var update = Builders<Posts>.Update.Set("likesUsersPost", likesUsersArray).Inc("likesPost", (likesIncDec) ? 1 : -1);
            posts.UpdateOne(filter, update);
        }
    }
}
