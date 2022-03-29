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
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string bufferUser;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btList_Click(object sender, RoutedEventArgs e)
        {
            var listToShow = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDBUsers())
            {
                listToShow.Add(item.Login);

            }
            User.ItemsSource = listToShow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Login = txtLogin.Text;
            var Name = txtName.Text;
            var Srename = txtSername.Text;
            var Maile = txtMail.Text;
            User user = new User(Login, Name, Srename, Maile);
            MongoExtensions.AddToDateBase(user);
            txtLogin.Clear();
            txtName.Clear();
            txtSername.Clear();
            txtMail.Clear();
        }

        private void addcustom_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MongoExtensions.GetListFromDBUsers())
            {
                if (userToaddd.Text == item.Login)
                {
                    if (first.Text == "" )
                    {
                        first.Text = userToaddd.Text;
                    }
                    else if (second.Text == ""&& first.Text != userToaddd.Text)
                    {
                        second.Text = userToaddd.Text;
                    }
                    else if(third.Text == "" && first.Text != userToaddd.Text && second.Text != userToaddd.Text)
                    {
                        third.Text = userToaddd.Text;

                    }
                    else if (fourth.Text == "" && first.Text != userToaddd.Text && second.Text != userToaddd.Text && third.Text != userToaddd.Text )
                    {
                        fourth.Text = userToaddd.Text;

                    }
                    else if (fivth.Text == "" && first.Text != userToaddd.Text && second.Text != userToaddd.Text && third.Text != userToaddd.Text && fourth.Text != userToaddd.Text)
                    {
                        fivth.Text = userToaddd.Text;

                    }
                    
                }
                

            }
            userToaddd.Clear();

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            first.Clear();
            second.Clear();
            third.Clear();
            fourth.Clear();
            fivth.Clear();
            TeamName.Clear();
            
        }

        private void addRundom_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var item in MongoExtensions.GetListFromDBUsers())
            {
                for (int i = 0; i < 10; i++)
                {

                    Random rnd = new Random();
                    int a = rnd.Next(2);

                    if (a == 1)
                    {

                    

                        if (first.Text == "")
                        {
                            first.Text = item.Login;
                        }
                        else if (second.Text == "" && first.Text != item.Login)
                        {
                            second.Text = item.Login;
                        }
                        else if (third.Text == "" && first.Text != item.Login && second.Text != item.Login)
                        {
                            third.Text = item.Login;

                        }
                        else if (fourth.Text == "" && first.Text != item.Login && second.Text != item.Login && third.Text != item.Login)
                        {
                            fourth.Text = item.Login;

                        }
                        else if (fivth.Text == "" && first.Text != item.Login && second.Text != item.Login && third.Text != item.Login && fourth.Text != item.Login)
                        {
                            fivth.Text = item.Login;

                        }

                    }
                }
            }
        }

        private void SaveTeam_Click(object sender, RoutedEventArgs e)
        {
            
            var Login1 = first.Text;
            var Login2 = second.Text;
            var Login3 = third.Text;
            var Login4= fourth.Text;
            var Login5 = fivth.Text;
            var Name = TeamName.Text;
            if (Name !="" && Login1 != "" && Login2 != "" && Login3 !="" && Login4 != "" && Login5 != "")
            {
            Team Teames = new Team(Name, Login1, Login2, Login3, Login4, Login5);
            MongoExtensions.AddToDateBaseTeam(Teames);
            first.Clear();
            second.Clear();
            third.Clear();
            fourth.Clear();
            fivth.Clear();
                TeamName.Clear();
            }
    }

        private void ListTeam_Click(object sender, RoutedEventArgs e)
        {
            var listToShow = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDBTeam())
            {
                listToShow.Add(item.TeamName);

            }
            Team.ItemsSource = listToShow;
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var item in MongoExtensions.GetListFromDBTeam())
            {
              
                if (Teamtxt.Text == item.TeamName)
                {
                    first.Text = item.Login1;
                    second.Text = item.Login2;
                    third.Text = item.Login3;
                    fourth.Text = item.Login4;
                    fivth.Text = item.Login5;
                    TeamName.Text = item.TeamName;
                }

            }
           
        }
    }
}
