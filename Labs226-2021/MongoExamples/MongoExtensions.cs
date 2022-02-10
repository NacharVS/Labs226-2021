using MongoDB.Driver;

namespace Labs226_2021.MongoExamples
{
    class MongoExtensions
    {
        public static void AddToDataBase(Admin admin)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("226Group");
            var collection = database.GetCollection<Admin>("Admins");
            collection.InsertOne(admin);
        }


    }
}