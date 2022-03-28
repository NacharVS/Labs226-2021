﻿using System;
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

        public static Character GetDataBase(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharacterEditor");
            var collection = database.GetCollection<Character>("Character");
            return collection.Find(x => x.nameCharacter == name).FirstOrDefault();
        }
        public static void UpdateBase(string name, Character character)
        {

            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharacterEditor");
            var collection = database.GetCollection<Character>("Character");
            collection.ReplaceOne(x => x.nameCharacter == name, character);
        }
    }
}
