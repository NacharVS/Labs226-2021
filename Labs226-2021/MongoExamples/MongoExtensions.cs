using MongoDB.Driver;

namespace Labs226_2021.MongoExamples
{
//      https://www.mongodb.com/try/download/community
//      https://www.mongodb.com/try/download/compass
    class MongoExtensions
    {
        static void AddToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
        }
    }
}
