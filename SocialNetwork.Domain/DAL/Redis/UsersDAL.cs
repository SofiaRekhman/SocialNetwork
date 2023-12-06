using SocialNetwork.Domain.Models.Redis;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.DAL.Redis
{
    public class UsersDAL
    {
        private static ConnectionMultiplexer _redisConnection;

        public UsersDAL(string redisConnectionString)
        {
            _redisConnection = ConnectionMultiplexer.Connect(redisConnectionString);
        }

        public static ConnectionMultiplexer Get_redisConnection()
        {
            return _redisConnection;
        }

        public static Users GetUserById(string userId)
        {
            var db = _redisConnection.GetDatabase();
            var userJson = db.StringGet($"user:{userId}");

            return userJson.IsNull ? null : Users.FromJson(userJson);
        }

        public static void SetUser(Users user, TimeSpan expiration)
        {
            var db = _redisConnection.GetDatabase();
            db.StringSet($"user:{user.Id}", user.ToJson(), expiration);
        }

        public static bool UserExists(string userId)
        {
            var db = _redisConnection.GetDatabase();
            return db.KeyExists($"user:{userId}");
        }

        public static void RemoveUser(string userId)
        {
            var db = _redisConnection.GetDatabase();
            db.KeyDelete($"user:{userId}");
        }
    }
}
