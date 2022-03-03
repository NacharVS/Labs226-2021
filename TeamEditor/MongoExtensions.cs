using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace TeamEditor
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

        public static List<User> GetListUser()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<User>("Users");
            return collection.Find(x => true).ToList();
        }
    }
}
