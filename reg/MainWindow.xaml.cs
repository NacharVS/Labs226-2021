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
using Labs226_2021.MongoExamples;
using MongoDB.Driver;

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
            var age = int.Parse(txtAge.Text);
            User user = new User(name, age);
            MongoExtensions.AddToDataBase(user);
            txtName.Clear();
            txtAge.Clear();
        }
    }
}