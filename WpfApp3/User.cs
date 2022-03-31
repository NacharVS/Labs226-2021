using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3
{
    class User
    {
        public User(string name, string searname, int age, int card)
        {
            Name = name;
            Searname = searname;
            Age = age;
            Card = card;
        }
        [BsonIgnoreIfDefault] public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        public string Searname { get; set; }
        [BsonIgnoreIfDefault]
        public int Age { get; set; }
        [BsonIgnoreIfDefault]
        public int Card { get; set; }
    }
}
