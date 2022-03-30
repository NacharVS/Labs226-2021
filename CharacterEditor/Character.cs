using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace CharacterEditor
{
    class Character: Unit
    {
        public Character(string nameCharacter, string classCharacter, double str, double dex, double intl, double con, int lvl, int exp, int expForCharact)
        {
            this.nameCharacter = nameCharacter;
            this.classCharacter = classCharacter;
            base.Str = str;
            base.Dex = dex;
            base.Intl = intl;
            base.Con = con;
            base.lvlCharacter = lvl;
            base.expCharacter = exp;
            this.expForCharact = expForCharact;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfDefault]
        public string nameCharacter { get; set; }
        [BsonIgnoreIfDefault]
        public string classCharacter { get; set; }
        [BsonIgnoreIfDefault]
        public int expForCharact { get; set; }
    }
}
