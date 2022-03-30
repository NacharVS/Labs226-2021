using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

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


        public string nameClassBuffer;

        Warrior warrior = new Warrior(0, 0, 0, 0);
        Archer archer = new Archer(0, 0, 0, 0);
        Wizard wizard = new Wizard(0, 0, 0, 0);
        CountingCharacteristics counting = new CountingCharacteristics();

        private int oldExp;
        private int MaxExp;

        List<string> parametersList = new List<string> 
        {
                "135,30,2,302",
                "135,71,2,260",
                "135,114,2,218",
                "135,157,2,175" 
        };

        private void MaxExpBuffer(int buffer)
        {
            MaxExp = buffer;
        }

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
            if (int.Parse(lblExp.Content.ToString()) > 0)
            {
                if (AddReduceBool == true)
                {
                    label.Content = int.Parse(label.Content.ToString()) + 1;
                    ParametersClass();
                    counting.StartedBonus = int.Parse(lblExp.Content.ToString());
                    counting.StartedBonus = counting.StartedBonus - 1;
                    lblExp.Content = counting.StartedBonus;
                }
            }

            if (AddReduceBool == false)
            {
                    if (int.Parse(lblExp.Content.ToString()) < MaxExp)
                    {
                        int checkLabel = int.Parse(label.Content.ToString());
                        label.Content = int.Parse(label.Content.ToString()) - 1;
                        ParametersClass();
                        if (int.Parse(label.Content.ToString()) != checkLabel)
                        {
                            counting.StartedBonus = int.Parse(lblExp.Content.ToString());
                            counting.StartedBonus = counting.StartedBonus + 1;
                            lblExp.Content = counting.StartedBonus;
                        }
                        
                    }
            }
        }

        private void bttAdd_Click(object sender, RoutedEventArgs e)
        {
            AddReduceBool = true;
            string buffMargin = bttAddReduce.Margin.ToString();
            if (buffMargin == parametersList[0]) { AddReduceOperation(lblStr); oldExp = int.Parse(lblStr.Content.ToString()); return; }
            else if (buffMargin == parametersList[1].ToString()) { AddReduceOperation(lblDex); oldExp = int.Parse(lblDex.Content.ToString()); return; }
            else if (buffMargin == parametersList[2]) { AddReduceOperation(lblInt); oldExp = int.Parse(lblInt.Content.ToString()); return; }
            else if (buffMargin == parametersList[3]) { AddReduceOperation(lblCon); oldExp = int.Parse(lblCon.Content.ToString()); return; };
        }

        private void bttReduce_Click(object sender, RoutedEventArgs e)
        {
            AddReduceBool = false;
            string buffMargin = bttAddReduce.Margin.ToString();
            if (buffMargin == parametersList[0]) { AddReduceOperation(lblStr); oldExp = int.Parse(lblStr.Content.ToString()); return; }
            else if (buffMargin == parametersList[1].ToString()) { AddReduceOperation(lblDex); oldExp = int.Parse(lblDex.Content.ToString()); return; }
            else if (buffMargin == parametersList[2]) { AddReduceOperation(lblInt); oldExp = int.Parse(lblInt.Content.ToString()); return; }
            else if (buffMargin == parametersList[3]) { AddReduceOperation(lblCon); oldExp = int.Parse(lblCon.Content.ToString()); return; };
        }


        public bool newChatacter = false;
        public void LoadingCharacter(string ClassName, string NameCharacter)
        {
            if (newChatacter == false)
            {
                switch (ClassName)
                {
                    case "Warrior":
                        classCharacterImage.Source = new BitmapImage(new Uri(@"Resources\imgWarrior2.jpg", UriKind.Relative));
                        break;
                    case "Archer":
                        classCharacterImage.Source = new BitmapImage(new Uri(@"Resources\imgArcher.jpg", UriKind.Relative));
                        break;
                    case "Wizard":
                        classCharacterImage.Source = new BitmapImage(new Uri(@"Resources\imgWizard2.jpg", UriKind.Relative));
                        break;
                }

                Character character = MongoExtensions.GetDataBase(NameCharacter);
                if (character != null)
                {
                    lblStr.Content = character.Str.ToString();
                    lblDex.Content = character.Dex.ToString();
                    lblInt.Content = character.Intl.ToString();
                    lblCon.Content = character.Con.ToString();
                    nameClassBuffer = character.classCharacter.ToString();
                    lblExp.Content = character.expForCharact.ToString();
                    lblNameChar.Content = character.nameCharacter.ToString();
                    lblLvl.Content = character.lvlCharacter.ToString();
                    lblLvlExp.Content = character.expCharacter.ToString();
                }
                

            }
            else if (newChatacter == true)
            {
                switch (nameClassBuffer)
                {
                    case "Warrior":
                        classCharacterImage.Source = new BitmapImage(new Uri(@"Resources\imgWarrior2.jpg", UriKind.Relative));
                        break;
                    case "Archer":
                        classCharacterImage.Source = new BitmapImage(new Uri(@"Resources\imgArcher.jpg", UriKind.Relative));
                        break;
                    case "Wizard":
                        classCharacterImage.Source = new BitmapImage(new Uri(@"Resources\imgWizard2.jpg", UriKind.Relative));
                        break;

                }
                Character character = MongoExtensions.GetDataBase(NameCharacter);
                MaxExpBuffer(character.expForCharact);
            }
            ParametersClass();
            СharacterCharacteristics(nameClassBuffer);
        }

        private void СharacterCharacteristics(string nameClass)
        {
            if (nameClass == "Wizard")
            {
                lblPDamage.Content = wizard.PDamage;
                lblPDefence.Content = wizard.PDefence;
                lblMDamage.Content = wizard.MDamage;
                lblMDefence.Content = wizard.MDefence;
                lblHealth.Content = wizard.Health;
                lblMagic.Content = wizard.Magic;

            }
            else if (nameClass == "Archer")
            {
                lblPDamage.Content = archer.PDamage;
                lblPDefence.Content = archer.PDefence;
                lblMDamage.Content = archer.MDamage;
                lblMDefence.Content = archer.MDefence;
                lblHealth.Content = archer.Health;
                lblMagic.Content = archer.Magic;
            }
            else if (nameClass == "Warrior")
            {
                lblPDamage.Content = warrior.PDamage;
                lblPDefence.Content = warrior.PDefence;
                lblMDamage.Content = warrior.MDamage;
                lblMDefence.Content = warrior.MDefence;
                lblHealth.Content = warrior.Health;
                lblMagic.Content = warrior.Magic;
            }
        }

        public void ParametersClass()
        {
            if (nameClassBuffer == "Wizard")
            {
                wizard.Str = int.Parse(lblStr.Content.ToString());
                wizard.Dex = int.Parse(lblDex.Content.ToString());
                wizard.Intl = int.Parse(lblInt.Content.ToString());
                wizard.Con = int.Parse(lblCon.Content.ToString());

                lblStr.Content = wizard.Str;
                lblDex.Content = wizard.Dex;
                lblInt.Content = wizard.Intl;
                lblCon.Content = wizard.Con;
            }
            else if (nameClassBuffer == "Archer")
            {
                archer.Str = int.Parse(lblStr.Content.ToString());
                archer.Dex = int.Parse(lblDex.Content.ToString());
                archer.Intl = int.Parse(lblInt.Content.ToString());
                archer.Con = int.Parse(lblCon.Content.ToString());

                lblStr.Content = archer.Str;
                lblDex.Content = archer.Dex;
                lblInt.Content = archer.Intl;
                lblCon.Content = archer.Con;
            }
            else if (nameClassBuffer == "Warrior")
            {
                warrior.Str = int.Parse(lblStr.Content.ToString());
                warrior.Dex = int.Parse(lblDex.Content.ToString());
                warrior.Intl = int.Parse(lblInt.Content.ToString());
                warrior.Con = int.Parse(lblCon.Content.ToString());

                lblStr.Content = warrior.Str;
                lblDex.Content = warrior.Dex;
                lblInt.Content = warrior.Intl;
                lblCon.Content = warrior.Con;
            }
        }

        bool cheatBool = false;
        private void bttCheat_Click(object sender, RoutedEventArgs e)
        {
            if (cheatBool == false)
            {
                gridCheat.Visibility = Visibility.Visible;
                cheatBool = true;
            }
            else
            {
                gridCheat.Visibility = Visibility.Hidden;
                cheatBool = false;
            }
        }

        private void bttGetFiveTh_Click(object sender, RoutedEventArgs e)
        {
            lblLvlExp.Content = int.Parse(lblLvlExp.Content.ToString()) + 5000;
            ChangeLvl();
        }

        private void bttGetThreeTh_Click(object sender, RoutedEventArgs e)
        {
            lblLvlExp.Content = int.Parse(lblLvlExp.Content.ToString()) + 3000;
            ChangeLvl();
        }

        private void bttGetOneTh_Click(object sender, RoutedEventArgs e)
        {
            lblLvlExp.Content = int.Parse(lblLvlExp.Content.ToString()) + 1000;
            ChangeLvl();
        }

        private void ChangeLvl()
        {
            int buffer = int.Parse(lblExp.Content.ToString());
            int nameBuffer = int.Parse(lblLvlExp.Content.ToString());
            if (nameBuffer <= 1000)
            {
                buffer += 5;
                lblLvl.Content = "2";
                MaxExpBuffer(buffer);
            }
            else if (nameBuffer <= 3000)
            {
                buffer += 5;
                lblLvl.Content = "3";
                MaxExpBuffer(buffer);
            }
            else if (nameBuffer <= 6000)
            {
                buffer += 5;
                lblLvl.Content = "4";
                MaxExpBuffer(buffer);
            }
            else if (nameBuffer <= 10000)
            {
                buffer += 5;
                lblLvl.Content = "5";
                MaxExpBuffer(buffer);
            }
            else if (nameBuffer <= 15000)
            {
                buffer += 5;
                lblLvl.Content = "6";
                MaxExpBuffer(buffer);
            }

            lblExp.Content = buffer.ToString();

        }

        private void bttRefresh_Click(object sender, RoutedEventArgs e)
        {
            СharacterCharacteristics(nameClassBuffer);
        }

        private void bttSaveParameters_Click(object sender, RoutedEventArgs e)
        {
            SaveParameters();
        }

        private void SaveParameters()
        {
            double strbuf = double.Parse(lblStr.Content.ToString());
            double dexbuf = double.Parse(lblDex.Content.ToString());
            double intlbuf = double.Parse(lblInt.Content.ToString());
            double conbuf = double.Parse(lblCon.Content.ToString());
            string nameBuffer = lblNameChar.Content.ToString();
            int lvl = int.Parse(lblLvl.Content.ToString());
            int exp = int.Parse(lblLvlExp.Content.ToString());
            int lvlexp = int.Parse(lblExp.Content.ToString());
            MongoExtensions.UpdateBase(nameBuffer, new Character(nameBuffer, nameClassBuffer, strbuf, dexbuf, intlbuf, conbuf, lvl, exp, lvlexp));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            SaveParameters();
        }
    }
}
