using System;
using MongoDB.Driver;
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

namespace WpfApp6
{
    class MongoExtensions
    {
        public static void AddToDateBaseWarier(War UserToadd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<War>("Wariers");
            collection.InsertOne(UserToadd);

        }
        public static void AddToDateBaseArcher(Archer TeamToadd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<Archer>("Archer");
            collection.InsertOne(TeamToadd);

        }
        public static void AddToDateBaseratmir(ratmirs TeamToadd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<ratmirs>("ratmir");
            collection.InsertOne(TeamToadd);

        }
        //public static List<warier> GetListFromDBWarier()
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Units");
        //    var collection = database.GetCollection<warier>("Warier");
        //    List<warier> users = collection.Find(x => true).ToList();
        //    return users;
        //}
        public static List<War> GetListFromDBWarier()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<War>("Wariers");
            List<War> Team = collection.Find(x => true).ToList();
            return Team;
        }
        public static List<Archer> GetListFromDBArcher()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<Archer>("Archer");
            List<Archer> Team = collection.Find(x => true).ToList();
            return Team;
        }
        public static List<ratmirs> GetListFromDBRatmir()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<ratmirs>("ratmir");
            List<ratmirs> Team = collection.Find(x => true).ToList();
            return Team;
        }
        public static void ReplaceUser(string login, War newUser)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<War>("Wariers");
          
            collection.ReplaceOne(x => x.login == login, newUser);
          
        }
        public static void ReplaceUserA(string login, Archer newUser)
        {
            //int lvl, int xp, int _int, int dex, int con, int str,
               var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<Archer>("Archer");
            //collection.ReplaceOne(x => x.Xp == xp, newUser);
            collection.ReplaceOne(x => x.login == login, newUser);
            //collection.ReplaceOne(x => x.Lvl == lvl, newUser);
            //collection.ReplaceOne(x => x.pts == pts, newUser);
            //collection.ReplaceOne(x => x._lvlstr == str, newUser);
            //collection.ReplaceOne(x => x._lvlcon == con, newUser);
            //collection.ReplaceOne(x => x._lvldex == dex, newUser);
            //collection.ReplaceOne(x => x._lvlint == _int, newUser);
        }
        public static void ReplaceUserR(string login, ratmirs newUser)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Units");
            var collection = database.GetCollection<ratmirs>("ratmir");
            //collection.ReplaceOne(x => x.Xp == xp, newUser);
            collection.ReplaceOne(x => x.login == login, newUser);
            //collection.ReplaceOne(x => x.Lvl == lvl, newUser);
            //collection.ReplaceOne(x => x.pts == pts, newUser);
            //collection.ReplaceOne(x => x._lvlstr == str, newUser);
            //collection.ReplaceOne(x => x._lvlcon == con, newUser);
            //collection.ReplaceOne(x => x._lvldex == dex, newUser);
            //collection.ReplaceOne(x => x._lvlint == _int, newUser);
        }
     
    }
}
