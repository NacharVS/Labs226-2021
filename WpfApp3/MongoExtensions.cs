using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    class MongoExtensions
    {
         public static void AddToDateBase(User UserToadd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("226Group");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(UserToadd);
        }
        public static List<User> GetListFromDB()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("226Group");
            var collection = database.GetCollection<User>("Users");
            List<User> Team = collection.Find(x => true).ToList();
            return Team;
        }
        public static void  ReplaceUser(string Name ,string searchName , int Agee, int Carrd, User newUser) 
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("226Group");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Name == Name  , newUser);
            collection.ReplaceOne(x => x.Searname == searchName, newUser);
            collection.ReplaceOne(x => x.Age == Agee, newUser);
            collection.ReplaceOne(x => x.Card == Carrd, newUser);
        }
    }
}
