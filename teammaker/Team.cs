using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace teammaker
{
    class Team
    {
        public Team(string teamName, string player1, string player2, string player3, string player4, string player5)
        {

            TeamName = teamName;
            this.player1 = player1;
            this.player2 = player2;
            this.player3 = player3;
            this.player4 = player4;
            this.player5 = player5;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfDefault]
        public string TeamName { get; set; }
        [BsonIgnoreIfDefault]
        public string player1 { get; set; }
        [BsonIgnoreIfDefault]
        public string player2 { get; set; }
        [BsonIgnoreIfDefault]
        public string player3 { get; set; }
        [BsonIgnoreIfDefault]
        public string player4 { get; set; }
        [BsonIgnoreIfDefault]
        public string player5 { get; set; }

    }
}