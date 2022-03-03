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
using MongoDB.Driver;

namespace TeamEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<string> bufferTeam = new List<string>();


        private void bttSaveUser_Click(object sender, RoutedEventArgs e)
        {
            string surname = txtSurnameUser.Text;
            string name = txtNameUser.Text;
            string patronymicu = txtPatronymicuUser.Text;

            MongoExtensions.AddToDataBase(new User(surname, name, patronymicu));

            txtNameUser.Clear();
            txtSurnameUser.Clear();
            txtPatronymicuUser.Clear();

            RefreshListUser();
        }

        private void bttSaveTeamToTeams_Click(object sender, RoutedEventArgs e)
        {
            if (listOneTeam.Items.Count < 5)
                MessageBox.Show("Your team has no players!");
            else
            {
                string teamName = txtTeamName.Text;
                string player1 = listOneTeam.Items[0].ToString();
                string player2 = listOneTeam.Items[1].ToString();
                string player3 = listOneTeam.Items[2].ToString();
                string player4 = listOneTeam.Items[3].ToString();
                string player5 = listOneTeam.Items[4].ToString();

                MongoExtensions.AddToDataBaseTeam(new Team(teamName, player1, player2, player3, player4, player5));

                txtNameUser.Clear();
                listOneTeam.Items.Clear();

                List<string> listbuf = new List<string>();
                foreach (Team Item in MongoExtensions.GetListTeam())
                {
                    listbuf.Add($"{Item.TeamName}");
                }

                listTeams.ItemsSource = listbuf;
            } 
        }



        private void bttAddToTeam_Click(object sender, RoutedEventArgs e)
        {
           

            bool userBool = true;
            var selectUser = listUsers.SelectedItem.ToString();
            if (listOneTeam.Items.Count <= 5)
            {
                if (listOneTeam.Items.Count > 0)
                {
                    foreach (var item in listOneTeam.Items)
                    {
                        if (item == selectUser)
                            userBool = false;
                    }
                    if (userBool == true)
                        listOneTeam.Items.Add(selectUser);
                }
                else
                    listOneTeam.Items.Add(selectUser);
            }
        }

        private void listUsers_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListUser();
            RefreshListTeams();
        }

        private void RefreshListUser()
        {

            List<string> listbuf = new List<string>();
            foreach (User Item in MongoExtensions.GetListUser())
            {
                listbuf.Add($"{Item.name} {Item.surname}");
            }

            listUsers.ItemsSource = listbuf;
        }
        private void RefreshListTeams()
        {
            List<string> listbuf = new List<string>();
            foreach (Team Item in MongoExtensions.GetListTeam())
            {
                listbuf.Add($"{Item.TeamName}");
            }

            listTeams.ItemsSource = listbuf;
        }

        private void bttRandomAddToTeam_Click(object sender, RoutedEventArgs e)
        {
            listOneTeam.Items.Clear();

            var randomUser = new Random();
            int[] array = new int[5];
            bool proverka = true;
            int k = 0;
            int p = 0;

            while (k < 5)
            {
                p = randomUser.Next(listUsers.Items.Count);
                bool b = true;
                for (int i = 0; i < k; i++)
                {
                    if (p == array[i])
                    {
                        b = false;
                        break;
                    }
                }

                if (b)
                {
                    array[k] = p;
                    k++;
                }
            }

            

            List<string> user = new List<string>();
            user.Clear();
            user.Add(listUsers.Items[array[0]].ToString());
            user.Add(listUsers.Items[array[1]].ToString());
            user.Add(listUsers.Items[array[2]].ToString());
            user.Add(listUsers.Items[array[3]].ToString());
            user.Add(listUsers.Items[array[4]].ToString());




            foreach (var Item in user)
            {
                listOneTeam.Items.Add(Item.ToString());
            }


        }

        private void bttClearTeam_Click(object sender, RoutedEventArgs e)
        {
            listOneTeam.Items.Clear();
        }

        private void listTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<Team>("Teams");

            string teamName = listTeams.SelectedItem.ToString();
            Team selectTeam;
            selectTeam = collection.Find(x => x.TeamName == teamName).FirstOrDefault();
            txtNameUser.Text = selectTeam.TeamName.ToString();
            //List<string> user = new List<string>();
            //user.Clear();
            //user.Add(selectTeam.player1.ToString());

            //foreach (var item in user)
            //{
            //    listOneTeam.Items.Add(user);
            //}
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Match");
            var collection = database.GetCollection<User>("Users");

            string teamName = listUsers.SelectedItem.ToString();
            User selectTeam;
            selectTeam = collection.Find(x => x.name == teamName).FirstOrDefault();

            txtNameUser.Text = selectTeam.name.ToString();
        }

        
    }
}
