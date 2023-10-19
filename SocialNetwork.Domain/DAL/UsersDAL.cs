using MongoDB.Bson;
using MongoDB.Driver;
using SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL
{
    public class UsersDAL
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase database = client.GetDatabase("Test");
        static IMongoCollection<Users> users = database.GetCollection<Users>("Users");

        public static string CheckLogin(string username, string password)
        {
            var foundUsername = users.Find(x => x.Username == username).FirstOrDefault();

            if (foundUsername == null)
            {
                throw new Exception("Not correct username");
            }
            else if (foundUsername.Password == password)
            {
                return foundUsername.Id;
            }
            else
            {
                throw new Exception("Not correct password");
            }
        }
        public static string FindUserProfile(string name)
        {
            var valueArr = name.Split(' ');
            var foundUser = users.Find(x => (x.FirstName == valueArr[0] && x.LastName == valueArr[1])).FirstOrDefault(); ;

            if (foundUser == null)
            {
                throw new Exception("No user with this name");
            }
            else
            {
                return foundUser.Id;
            }
        }

        public static Users GetUserById(string userIdCurrent)
        {
            return users.Find(x => x.Id == userIdCurrent).FirstOrDefault();
        }
        public static List<string> GetFollowers (string userIdCurrent)
        {
            List<string> nameFollowers = new List<string>();

            var userInfo = GetUserById(userIdCurrent);
            var followers = userInfo.Followers;

            foreach (var f in followers)
            {
                nameFollowers.Add(GetUserById(f).Username);
            }
            return nameFollowers;
        }
        public static bool IsFollower(string userIdCurrent, string userIdProfile)
        {
            return (users.Find(x => x.Id == userIdCurrent).FirstOrDefault().Followers.Contains(userIdProfile)) ? true : false;
        }

        public static void NewFollowUser(string userIdCurrent, string userIdProfile)
        {
            var followArray = users.Find(x => x.Id == userIdCurrent).Project("{_id:0,followers:1}").FirstOrDefault().First().Value.AsBsonArray;
            if (IsFollower(userIdCurrent, userIdCurrent)) { }
            else if (IsFollower(userIdCurrent, userIdProfile))
                followArray.Remove(userIdProfile);
            else
                followArray.Add(userIdProfile);
            
            var filter = Builders<Users>.Filter.Eq(x => x.Id, userIdCurrent);
            var update = Builders<Users>.Update.Set("followers", followArray.AsObjectId);
            users.UpdateOne(filter, update);

        }
        public static void NewUserSignIn(string firstname, string lastname, string email, string username, string password)
        {
            var newUserId = ObjectId.GenerateNewId();
            var newUser = new Users
            {
                Id = newUserId.ToString(),
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Username = username,
                Password = password
            };
            users.InsertOne(newUser);
        }

        public static void DeleteUser (string username, string password)
        {

            var userId = CheckLogin(username, password);
            var documentIdToDelete = ObjectId.Parse(userId).ToString(); 

            var filter = Builders<Users>.Filter.Eq(u => u.Id, documentIdToDelete);

            var deleteResult = users.DeleteOne(filter);

        }
    }
}
