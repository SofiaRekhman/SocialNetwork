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
                UsersDALNeo4j.PathLength(userId, getId), PostsDAL.GetUserPosts(getId));
        }
    }
}
