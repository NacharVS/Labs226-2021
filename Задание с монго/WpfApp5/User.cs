using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp5
{
    class User
    {
        public User(string login, string name, string sername, string mail)
        {
            Login = login;
            Name = name;
            Sername = sername;
            Mail = mail;
        }
        [BsonIgnoreIfDefault] public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public string Login { get; set; }
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public string Sername { get; set; }
        [BsonIgnoreIfDefault]
        public string Mail { get; set; }
    }
}
