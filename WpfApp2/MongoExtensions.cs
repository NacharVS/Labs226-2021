using Microsoft.VisualBasic;
using MongoDB.Driver;
using System;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfApp2
{
    class MongoExtensions
    {
        public static void AddToDataBase(Uber uberToAdd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("226Group");
            var collection = database.GetCollection<Uber>("Users");
            collection.InsertOne(uberToAdd);
        }
    }
}
