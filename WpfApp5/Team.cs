using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
namespace WpfApp5
{
    class Team
    {
        public Team(string Name, string first , string shecond , string therd , string fierst , string fives)
        {
            Login1 = first;
            Login2 = shecond;
            Login3 = therd;
            Login4 = fierst;
            Login5= fives;
            TeamName = Name;
        }
        [BsonIgnoreIfDefault] public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public string Login1 { get; set; }
        [BsonIgnoreIfNull]
        public string Login2 { get; set; }
        [BsonIgnoreIfDefault]
        public string Login3 { get; set; }
        [BsonIgnoreIfDefault]
        public string Login4 { get; set; }
        [BsonIgnoreIfDefault]
        public string Login5 { get; set; }
        [BsonIgnoreIfDefault]
        public string TeamName { get; set; }
    }
}
