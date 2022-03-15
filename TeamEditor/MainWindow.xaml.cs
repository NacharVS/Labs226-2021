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
            CheckingQuantity();
        }

        private void bttSaveTeamToTeams_Click(object sender, RoutedEventArgs e)
        {
            if (listOneTeam.Items.Count < 5)
                MessageBox.Show("В вашей команде нет игроков!", "Предупреждение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            else
            {
                string TeamNameBuffer = txtTeamName.Text.Trim(new char[] { ' ', ' ' });
                if (TeamNameBuffer != "Team name" && TeamNameBuffer != "")
                {
                    Team TeamNameCheck = MongoExtensions.GetTeam(txtTeamName.Text);

                    if (TeamNameCheck == null)
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
                        txtTeamName.Clear();

                        listTeams.SelectedIndex = 0;
                    }
                    else 
                    {
                        MessageBox.Show($"Команда с таким названием ({TeamNameCheck.TeamName}) уже существует!", "Предупреждение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Введите название команды", "Подсказка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }  
            } 


        }

        private void bttAddToTeam_Click(object sender, RoutedEventArgs e)
        { 
            if (this.listUsers.SelectedItems.Count == 0)
                 MessageBox.Show("Выберите игрока!", "Подсказка",
                     MessageBoxButton.OK,
                     MessageBoxImage.Information); 
            else 
            {
                bool userBool = true;
                var selectUser = listUsers.SelectedItem.ToString();
                if (listOneTeam.Items.Count < 5)
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
        }

        private void listUsers_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListUser();
            RefreshListTeams();
            CheckingQuantity();
        }

        private void RefreshListUser()
        {

            List<string> listbuf = new List<string>();
            foreach (User Item in MongoExtensions.GetListUser())
            {
                listbuf.Add($"{Item.surname} {Item.name}");
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
            int k = 0;
            int p = 0;

            while (k < 5)
            {
                p = randomUser.Next(listUsers.Items.Count);
                bool b = true;
                for (int i = 0; i < k; i++)
                {
                    if (p == array[i]) {b = false; break;}
                }

                if (b) {array[k] = p;  k++; }
            }

            List<string> user = new List<string>();
            user.Clear();
            for (int i = 0; i <= 4; i++)
            {
                user.Add(listUsers.Items[array[i]].ToString());
            }

            foreach (var Item in user)
            {
                listOneTeam.Items.Add(Item.ToString());
            }
        }

        private void bttClearTeam_Click(object sender, RoutedEventArgs e)
        {
            listOneTeam.Items.Clear();
            txtTeamName.Clear();
            listUsers.SelectedIndex = -1;
        }

        private void listTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listTeamComposition.Items.Clear();

            string teamName = listTeams.SelectedItem.ToString();
            if (teamName != null)
            {
                Team selectTeam = MongoExtensions.GetTeam(teamName);

                if (selectTeam != null)
                {
                    string teamNameBuffer = selectTeam.TeamName.ToString();
                    gbTeamName.Header = $"Team {teamNameBuffer}";
                    listTeamComposition.Items.Add(selectTeam.player1.ToString());
                    listTeamComposition.Items.Add(selectTeam.player2.ToString());
                    listTeamComposition.Items.Add(selectTeam.player3.ToString());
                    listTeamComposition.Items.Add(selectTeam.player4.ToString());
                    listTeamComposition.Items.Add(selectTeam.player5.ToString());
                }
            }
        }

        private void bttChangeTeam_Click(object sender, RoutedEventArgs e)
        {
            int oldUser;
            string newUser;

            if (listOneTeam.SelectedIndex != -1 && listUsers.SelectedIndex != -1)
            {
                oldUser = listOneTeam.SelectedIndex;
                newUser = listUsers.SelectedItem.ToString();
                foreach (var item in listOneTeam.Items)
                {
                    if (newUser == item)
                    {
                        MessageBox.Show("Игрока, которого вы выбрали, уже есть в команде", "Предупреждение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                        return;
                    }
                }

                listOneTeam.Items.RemoveAt(oldUser);
                listOneTeam.Items.Insert(oldUser, newUser);
            }
            else 
            { 
                MessageBox.Show("Вы не выбрали игрока", "Предупреждение",
                MessageBoxButton.OK,
                MessageBoxImage.Warning); 
            }
        }


        private void listTeams_Loaded(object sender, RoutedEventArgs e)
        {
            if (listTeams.Items.Count > 0)
            {
                listTeams.SelectedIndex = 0;
            }
        }

        private void CheckingQuantity()
        {
            if (listUsers.Items.Count < 5)
            {
                bttSaveTeamToTeams.IsEnabled = false;
                bttRandomAddToTeam.IsEnabled = false;
            }
            else
            {
                bttSaveTeamToTeams.IsEnabled=true;
                bttRandomAddToTeam.IsEnabled=true;
            }
        }

        private void ClearTeam(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Delete' работает некорректно");

            //string teamName = listTeams.SelectedItem.ToString();
            //MongoExtensions.DeletingTeam(teamName);
            //RefreshListTeams();
        }
    }
}
