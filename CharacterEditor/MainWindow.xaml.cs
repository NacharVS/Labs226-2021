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
        Window1 task = new Window1();
        Warrior warrior = new Warrior(0, 0, 0, 0);
        Archer archer = new Archer(0, 0, 0, 0);
        Wizard wizard = new Wizard(0, 0, 0, 0);
        private void gridSelectWizard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DefaultSizeColorBorder();
            borderWizard.BorderBrush = Brushes.Green;
            borderWizard.BorderThickness = new Thickness(5);
            task.nameClassBuffer = "Wizard";

        }

        private void gridSelectArcher_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DefaultSizeColorBorder();
            borderArcher.BorderBrush = Brushes.Green;
            borderArcher.BorderThickness = new Thickness(5);
            task.nameClassBuffer = "Archer";
        }

        private void gridSelectWarrior_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DefaultSizeColorBorder();
            borderWarrior.BorderBrush = Brushes.Green;
            borderWarrior.BorderThickness = new Thickness(5);
            task.nameClassBuffer = "Warrior";
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
            string NameBuffer = txtCharacterName.Text.Trim(new char[] { ' ', ' ' });
            if (NameBuffer != "" && task.nameClassBuffer != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите продолжить?",
                "Сообщение",
                MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    string nameCharacter = txtCharacterName.Text.ToString();
                    string nameClass = task.nameClassBuffer.ToString();

                    double strBuf = 0;
                    double dexBuf = 0;
                    double intlBuf = 0;
                    double conBuf = 0;
                    int lvlbuf = 0;
                    int expBuf = 0;

                    switch (task.nameClassBuffer)
                    {
                        case "Warrior":
                            strBuf = warrior.Str;
                            dexBuf = warrior.Dex;
                            intlBuf = warrior.Intl;
                            conBuf = warrior.Con;
                            break;
                        case "Archer":
                            strBuf = archer.Str;
                            dexBuf = archer.Dex;
                            intlBuf = archer.Intl;
                            conBuf = archer.Con;
                            break;
                        case "Wizard":
                            strBuf = wizard.Str;
                            dexBuf = wizard.Dex;
                            intlBuf = wizard.Intl;
                            conBuf = wizard.Con;
                            break;
                    }

                    MongoExtensions.AddToDataBase(new Character(nameCharacter, nameClass, strBuf, dexBuf, intlBuf, conBuf, lvlbuf, expBuf));
                    task.lblNameChar.Content = nameCharacter.ToString();
                    task.Show();
                    task.LoadingCharacter(nameClass, nameCharacter);
                    task.lblExp.Content = 10;
                    this.Close();
                }
            }   
        }

        

    }
}
