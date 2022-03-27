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

        
    }
}
