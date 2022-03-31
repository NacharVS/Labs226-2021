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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btRegistr_Click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            var searname = txtSerName.Text;
            var age =int.Parse( txtAge.Text);
            var Card =int.Parse( txtCard.Text);
            User user = new User(name, searname, age, Card);
            MongoExtensions.AddToDateBase(user);
            txtName.Clear();
            txtSerName.Clear();
            txtAge.Clear();
            txtCard.Clear();
        }
        private void btList_Click(object sender, RoutedEventArgs e)
        {
            var listToShow = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDB())
            {
                listToShow.Add(item.Name);

            }
            ListOfUsers.ItemsSource = listToShow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btList.Visibility = Visibility.Hidden;
            btRegistr.Visibility = Visibility.Hidden;
            var listToShow = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDB())
            {
                if (txtsearcName.Text == item.Name)
                {
                    txtName.Text = item.Name;
                    txtSerName.Text = item.Searname;
                    txtAge.Text = Convert.ToString(item.Age);
                    txtCard.Text = Convert.ToString(item.Card);

                }

            }
          
        }

        private void btReplace_Click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            var searname = txtSerName.Text;
            var age = int.Parse(txtAge.Text);
            var Card = int.Parse(txtCard.Text);
            MongoExtensions.ReplaceUser(txtsearcName.Text,txtsearcName.Text,int.Parse(txtAge.Text),int.Parse(txtCard.Text), new User($"{name}",$" {searname} ",age,Card));
            txtName.Clear();
            txtSerName.Clear();
            txtCard.Clear();
            txtAge.Clear();
            var listToShow = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDB())
            {
                listToShow.Add(item.Name);

            }
            ListOfUsers.ItemsSource = listToShow;
            btList.Visibility = Visibility.Visible;
            btRegistr.Visibility = Visibility.Visible;
        }
    }
}
