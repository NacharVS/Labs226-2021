using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;


namespace CharacterEditor
{
    class Character: Unit
    {
        public Character(string nameCharacter, string classCharacter, double str, double dex, double intl, double con, int lvl, int exp)
        {
            this.nameCharacter = nameCharacter;
            this.classCharacter = classCharacter;
            this.lvlCharacter = lvl;
            this.expCharacter = exp;
            base.Str = str;
            base.Dex = dex;
            base.Intl = intl;
            base.Con = con;
            
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfDefault]
        public string nameCharacter { get; set; }
        [BsonIgnoreIfDefault]
        public string classCharacter { get; set; }
        [BsonIgnoreIfDefault]
        public int lvlCharacter { get; set; }
        [BsonIgnoreIfDefault]
        public int expCharacter { get; set; }



    }
}
