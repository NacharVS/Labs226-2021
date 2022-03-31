using MongoDB.Driver;
using System;

namespace Labs226_2021.MongoExamples
{
    class MongoExtensions
    {

        internal static void AddToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("226Group");
            var collection = database.GetCollection<Admin>("Admins");
        }
    }
}