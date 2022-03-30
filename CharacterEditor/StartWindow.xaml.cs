using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace CharacterEditor
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void listUser_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listbuf = new List<string>();
            foreach (Character Item in MongoExtensions.GetListUser())
            {
                listbuf.Add($"{Item.nameCharacter}");
            }
            listUser.ItemsSource = listbuf;
        }

        private void listUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CharacterParameters();
        }

        private void CharacterParameters()
        {
            listParameters.Items.Clear();

            string nameCharacter = listUser.SelectedItem.ToString();
            if (nameCharacter != null)
            {
                Character selectTeam = MongoExtensions.GetParametesUser(nameCharacter);

                if (selectTeam != null)
                {
                    listParameters.Items.Add(selectTeam.Str.ToString());
                    listParameters.Items.Add(selectTeam.Dex.ToString());
                    listParameters.Items.Add(selectTeam.Intl.ToString());
                    listParameters.Items.Add(selectTeam.Con.ToString());
                }
            }
        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            if (listUser.SelectedIndex.ToString() != "-1")
            {
                Window1 task = new Window1();
                task.Show();
                Character character = MongoExtensions.GetDataBase(listUser.SelectedItem.ToString());
                if (character != null)
                {
                    task.LoadingCharacter(character.classCharacter, character.nameCharacter);
                }
                this.Close();
            }
        }

        private void newCharacter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow task = new MainWindow();
            task.Show();
            this.Close();
        }
    }
}
