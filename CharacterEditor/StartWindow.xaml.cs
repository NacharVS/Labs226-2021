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

        bool activate = true;

        private void listUser_Loaded(object sender, RoutedEventArgs e)
        {
            listUserRefresh();
        }

        private void listUserRefresh()
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
            if (activate == true)
            {
                CharacterParameters();
            }
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
                    listParameters.Items.Add($"Сила - {selectTeam.Str}");
                    listParameters.Items.Add($"Ловкость - {selectTeam.Dex}");
                    listParameters.Items.Add($"Интеллект - {selectTeam.Intl}");
                    listParameters.Items.Add($"Выносливость - {selectTeam.Con}");
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

        private void bttDeleteCharacter_Click(object sender, RoutedEventArgs e)
        {
            activate = false;
            string name = listUser.SelectedItem.ToString();
            listUser.SelectedIndex = -1;
            MongoExtensions.DeletingCharacter(name);    
            listUserRefresh();
            listParameters.Items.Clear();
            activate = true;

        }
    }
}
