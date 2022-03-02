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

            RefreshList();
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
            RefreshList();
        }

        private void RefreshList()
        {

            List<string> listbuf = new List<string>();
            foreach (User Item in MongoExtensions.GetListUser())
            {
                listbuf.Add($"{Item.name} {Item.surname}");
            }

            listUsers.ItemsSource = listbuf;
        }

        private void bttRandomAddToTeam_Click(object sender, RoutedEventArgs e)
        {
            var randomUser = new Random();
            int[] array = new int[5];
            bool proverka = true;
            

            for (int i = 0; i < array.Length; i++)
            {
                int buf = 0;
                for (int k = 0; k < array.Length; k++)
                {
                    buf = randomUser.Next(5);
                    if (buf == array[k])
                    {
                        proverka = false;
                        break;
                    }
                    
                    
                }
                if(proverka == true)
                    array[i] = buf;
            }

            bttRandomAddToTeam.Content =  $"{array[0]}{array[1]}{array[2]}{array[3]}{array[4]}";



        }
    }
}
