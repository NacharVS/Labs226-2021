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
        public Character(string nameCharacter, string classCharacter, double str, double dex, double intl, double con)
        {
            this.nameCharacter = nameCharacter;
            this.classCharacter = classCharacter;
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
        

        
    }
}
