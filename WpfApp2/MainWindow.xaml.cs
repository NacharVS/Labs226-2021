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
using WpfApp2;

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
            var n = txtName.Text;
            var s = txtSerName.Text;
            var a = txtAge.Text;
            var c = txtCard.Text;
            Uber uber = new Uber(n, s, a, c);
            MongoExtensions.AddToDataBase(uber);
            txtName.Clear();
            txtSerName.Clear();
            txtAge.Clear();
            txtCard.Clear();
        }
    }
}