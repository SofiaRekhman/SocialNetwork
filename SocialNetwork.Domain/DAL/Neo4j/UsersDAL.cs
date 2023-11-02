using Neo4jClient;
using SocialNetwork.Domain.Models.Neo4j.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient.Cypher;
using MongoDB.Driver.Core.Configuration;
using Nest;
using SocialNetwork.Domain.Models.Neo4j.Followers;
using SocialNetwork.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace SocialNetwork.Domain.DAL.Neo4j.UsersDAL
{
    public class UsersDALNeo4j
    {

        public static GraphClient client = new GraphClient(new Uri("http://localhost:7687/"), "neo4j", "qwertyuiop");

        public static void CreateUser(string firstname, string lastname, string username)
        {
            var newUser = new Users
            {
                FirstName = firstname,
                LastName = lastname,
                Username = username
            };
            client.ConnectAsync().Wait();
            client.Cypher
                .Create("(usr:User $newUser)")
                .WithParam("newUser", newUser)
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static void DeleteUser(string username)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(usr:User{username: $userName})")
                .WithParam("userName", username)
                .DetachDelete("usr")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static void CreateFriendConnection(string current_user, string new_friend)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(crUser:User {username: $crtUser})", "(nwFriend:User {username: $newFrnd})")
                .WithParam("crtUser", current_user)
                .WithParam("newFrnd", new_friend)
                .Create("(crUser)-[:IsFriend]->(nwFriend)")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static void DeleteFriendConnection(string current_user, string old_friend)
        {
            client.ConnectAsync().Wait();
            client.Cypher
                .Match("(crUser:User {username: $crtUser})-[p:IsFriend]->(oldFriend:User {username: $oldFrnd})")
                .WithParam("crtUser", current_user)
                .WithParam("oldFrnd", old_friend)
                .Delete("p")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public static bool CheckFriendConnection(string current_user, string friend)
        {
            client.ConnectAsync().Wait();
            string checker = client.Cypher
                .OptionalMatch("(crUser:User {username: $crtUser})-[p:IsFriend]->(friend:User {username: $frnd})")
                .WithParam("crtUser", current_user)
                .WithParam("frnd", friend)
                .Limit(1)
                .Return(p => Return.As<string>("coalesce(type(p), 'No')"))
                .ResultsAsync.Result.Single();

            if (checker.Equals("No"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int PathLength(string current_user, string person)
        {
            client.ConnectAsync().Wait();
            int length = client.Cypher
                .Match("p = shortestPath((crUser:User {username: $crtUser})-[*]->(person:User {username: $prsn}))")
                .WithParam("crtUser", current_user)
                .WithParam("prsn", person)
                .Return(p => Return.As<int>("length(p)"))
                .ResultsAsync.Result.Single();

            return length;
        }
    }
}
