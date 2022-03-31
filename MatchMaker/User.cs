using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MatchMaker
{
    class User
    {
        public User(string surname, string name, string patronymicu)
        {

            this.surname = surname;
            this.name = name;
            this.Patronymicu = patronymicu;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfDefault]
        public string name { get; set; }
        [BsonIgnoreIfDefault]
        public string surname { get; set; }
        [BsonIgnoreIfDefault]
        public string Patronymicu { get; set; }

    }
}
