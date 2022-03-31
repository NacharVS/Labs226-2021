using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace teammaker
{
    class MongoExtensions
    {
        public static void AddToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static void AddToDataBaseTeam(Team team)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<Team>("Teams");
            collection.InsertOne(team);
        }

        public static List<User> GetListUser()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<User>("Users");
            return collection.Find(x => true).ToList();
        }

        public static List<Team> GetListTeam()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<Team>("Teams");
            return collection.Find(x => true).ToList();
        }

        public static Team GetTeam(string team)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<Team>("Teams");
            return collection.Find(x => x.TeamName == team).FirstOrDefault();
        }

        public static void DeletingTeam(string team)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<Team>("Teams");
            collection.DeleteOne(x => x.TeamName == team);
        }
    }
}