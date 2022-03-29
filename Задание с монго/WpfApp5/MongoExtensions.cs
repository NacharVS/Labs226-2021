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

namespace WpfApp5
{
    class MongoExtensions
    {
        public static void AddToDateBase(User UserToadd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Team");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(UserToadd);
           
        }
        public static void AddToDateBaseTeam(Team TeamToadd)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Team");
            var collection = database.GetCollection<Team>("Teams");
            collection.InsertOne(TeamToadd);

        }
        public static List<User> GetListFromDBUsers()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Team");
            var collection = database.GetCollection<User>("Users");
            List<User> users = collection.Find(x => true).ToList();
            return users;
        }
        public static List<Team> GetListFromDBTeam()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Team");
            var collection = database.GetCollection<Team>("Teams");
            List<Team> Team = collection.Find(x => true).ToList();
            return Team;
        }    
    }
}
