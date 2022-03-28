using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace CharacterEditor
{
    class MongoExtensions
    {
        public static void AddToDataBase(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharacterEditor");
            var collection = database.GetCollection<Character>("Character");
            collection.InsertOne(character);
        }
    }
}
