using Microsoft.VisualBasic.ApplicationServices;
using SocialNetwork.DAL;
using SocialNetwork.Domain.DAL;
using SocialNetwork.Domain.Models;
using SocialNetwork.Domain.Models.Redis;
using SocialNetwork.Models;
using System;
using Users = SocialNetwork.Models.Users;

namespace SocialNetwork.Domain.BLL
{
    public class UserService
    {
        private readonly SocialNetwork.Domain.DAL.Redis.UsersDAL _redisRepository;

        public Users GetUserById(string userId)
        {
            var redisUser = SocialNetwork.Domain.DAL.Redis.UsersDAL.GetUserById(userId);

            if (redisUser != null)
            {
                return redisUser;
            }
            else
            {
                var mongoUser = SocialNetwork.DAL.UsersDAL.GetUserById(userId);

                if (mongoUser != null)
                {
                    SocialNetwork.Domain.DAL.Redis.UsersDAL.SetUser(mongoUser, TimeSpan.FromMinutes(30));
                }

                return mongoUser;
            }
        }

        public void AddUser(string userId, string userIdCurrent, SocialNetwork.Domain.Models.Redis.Users user)
        {
             SocialNetwork.DAL.UsersDAL.NewFollowUser(userId, userIdCurrent);
            SocialNetwork.Domain.DAL.Redis.UsersDAL.SetUser(user, TimeSpan.FromMinutes(30));
        }

        public static void RemoveUser(string userId)
        {
            var userToDelete = SocialNetwork.DAL.UsersDAL.GetUserById(userId);
            SocialNetwork.DAL.UsersDAL.DeleteUser(userToDelete.Username, userToDelete.Password);
            SocialNetwork.Domain.DAL.Redis.UsersDAL.RemoveUser(userId);
        }
    }
}
