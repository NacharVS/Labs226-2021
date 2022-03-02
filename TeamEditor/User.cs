using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace TeamEditor
{
    class User
    {
        public User(string surname, string name, string patronymicu)
        {

            this.surname = surname;
            this.name = name;
            this.Patronymicu = patronymicu;
        }

        public ObjectId _id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string Patronymicu { get; set; }

    }
}
