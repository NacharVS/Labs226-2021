using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CharacterEditor
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public int numberClass = 2;

        List<string> className = new List<string>
        {
            "gridSelectArcher",
            "gridSelectWizard",
            "gridSelectWarrior"
        };

        List<string> parametersList = new List<string> 
        {
                "135,30,2,302",
                "135,71,2,260",
                "135,114,2,218",
                "135,157,2,175" 
        };


        bool AddReduceBool = true;

        private void lblStr_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bttAddReduce.Margin = new Thickness(135, 30, 2, 302);
        }

        private void lblDex_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bttAddReduce.Margin = new Thickness(135, 71, 2, 260);
        }

        private void lblInt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bttAddReduce.Margin = new Thickness(135, 114, 2, 218);
        }

        private void lblCon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bttAddReduce.Margin = new Thickness(135, 157, 2, 175);
        }

        private void AddReduceOperation(Label label)
        {
            if (AddReduceBool == true)
            {
                label.Content = int.Parse(label.Content.ToString()) + 1;
            }
            else if (AddReduceBool == false)
            {
                label.Content = int.Parse(label.Content.ToString()) - 1;
            }
        }

        private void bttAdd_Click(object sender, RoutedEventArgs e)
        {
            AddReduceBool = true;
            string buffMargin = bttAddReduce.Margin.ToString();
            if (buffMargin == parametersList[0]) { AddReduceOperation(lblStr); return; }
            else if (buffMargin == parametersList[1].ToString()) { AddReduceOperation(lblDex); return; }
            else if (buffMargin == parametersList[2]) { AddReduceOperation(lblInt); return; }
            else if (buffMargin == parametersList[3]) { AddReduceOperation(lblCon); return; };
        }

        private void bttReduce_Click(object sender, RoutedEventArgs e)
        {
            AddReduceBool = false;
            string buffMargin = bttAddReduce.Margin.ToString();
            if (buffMargin == parametersList[0]) { AddReduceOperation(lblStr); return; }
            else if (buffMargin == parametersList[1].ToString()) { AddReduceOperation(lblDex); return; }
            else if (buffMargin == parametersList[2]) { AddReduceOperation(lblInt); return; }
            else if (buffMargin == parametersList[3]) { AddReduceOperation(lblCon); return; };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ParametersClass();
        }
        private void ParametersClass()
        {
            if (numberClass == 1) //Wizard
            {
                Wizard unit = new Wizard();
                unit.Str = 0;
                unit.Dex = 0;
                unit.Intl = 0;
                unit.Con = 0;
                lblStr.Content = unit.Str;
                lblDex.Content = unit.Dex;
                lblInt.Content = unit.Intl;
                lblCon.Content = unit.Con;
            }
            else if (numberClass == 2) //Archer
            {
                Archer unit = new Archer();
                unit.Str = 20;
                unit.Dex = 30;
                unit.Intl = 15;
                unit.Con = 20;
                lblStr.Content = unit.Str;
                lblDex.Content = unit.Dex;
                lblInt.Content = unit.Intl;
                lblCon.Content = unit.Con;
            }
            else if (numberClass == 3)
            {
                Warrior unit = new Warrior(); //Warrior
                unit.Str = 0;
                unit.Dex = 0;
                unit.Intl = 0;
                unit.Con = 0;
                lblStr.Content = unit.Str;
                lblDex.Content = unit.Dex;
                lblInt.Content = unit.Intl;
                lblCon.Content = unit.Con;
            }
        }



    }
}
