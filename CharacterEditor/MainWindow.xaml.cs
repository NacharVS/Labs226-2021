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

namespace CharacterEditor
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

        private void gridSelectWizard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DefaultSizeColorBorder();
            borderWizard.BorderBrush = Brushes.Green;
            borderWizard.BorderThickness = new Thickness(5);
            Window1 task = new Window1();
            task.numberClass = 1;

        }

        private void gridSelectArcher_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DefaultSizeColorBorder();
            borderArcher.BorderBrush = Brushes.Green;
            borderArcher.BorderThickness = new Thickness(5);
            Window1 task = new Window1();
            task.numberClass = 2;
        }

        private void gridSelectWarrior_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DefaultSizeColorBorder();
            borderWarrior.BorderBrush = Brushes.Green;
            borderWarrior.BorderThickness = new Thickness(5);
            Window1 task = new Window1();
            task.numberClass = 3;
        }

        private void DefaultSizeColorBorder()
        {
            borderWizard.BorderBrush = Brushes.Black;
            borderArcher.BorderBrush = Brushes.Black;
            borderWarrior.BorderBrush = Brushes.Black;

            borderWizard.BorderThickness = new Thickness(2, 2, 2, 2);
            borderArcher.BorderThickness = new Thickness(2, 2, 2, 2);
            borderWarrior.BorderThickness = new Thickness(2, 2, 2, 2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите продолжить?",
                "Сообщение",
                MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Window1 taskWindow = new Window1();
                taskWindow.Show();
                this.Close();
            } 
        }

    }
}
