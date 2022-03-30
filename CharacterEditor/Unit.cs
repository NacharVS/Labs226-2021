namespace CharacterEditor
{
    class Unit
    {
        private double _str;
        private double _dex;
        private double _con;
        private double _intl;
        private int _lvlCharacter;
        private int _expCharacter;

        public virtual double Str { get => _str; set => _str = value; }
        public virtual double Dex { get => _dex; set => _dex = value; }
        public virtual double Con { get => _con; set => _con = value; }
        public virtual double Intl { get => _intl; set => _intl = value; }
        public virtual int lvlCharacter { get => _lvlCharacter; set => _lvlCharacter = value; }
        public virtual int expCharacter { get => _expCharacter; set => _expCharacter = value; }
    }
}
