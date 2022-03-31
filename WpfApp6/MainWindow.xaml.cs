using System;
using System.Collections;
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

namespace WpfApp6
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

        private void btwarier_Click(object sender, RoutedEventArgs e)
        {

            var Login = txtName.Text;
            var lvl = 0;
            var xp = 0;
            var dex = 0;
            var _int = 0;
            var str = 0;
            var con = 0;
            var pts = 0;
            War user = new War(Login, lvl, xp, pts, con, dex, _int, str);
            MongoExtensions.AddToDateBaseWarier(user);
            txtName.Clear();


        }

        private void btarcher_Click(object sender, RoutedEventArgs e)
        {
            var Login = txtName.Text;
            var lvl = 0;
            var xp = 0;
            var dex = 0;
            var _int = 0;
            var str = 0;
            var con = 0;
            var pts = 0;
            Archer user = new Archer(Login, lvl, xp,pts,con,dex,_int,str);
            MongoExtensions.AddToDateBaseArcher(user);
            txtName.Clear();

        }

        private void btratmir_Click(object sender, RoutedEventArgs e)
        {
            var Login = txtName.Text;
            var lvl = 0;
            var xp = 0;
            var dex = 0;
            var _int = 0;
            var str = 0;
            var con = 0;
            var pts = 0;
            ratmirs user = new ratmirs(Login, lvl, xp, pts, con, dex, _int, str);
            MongoExtensions.AddToDateBaseratmir(user);
            txtName.Clear();
        }

        private void btlist_Click(object sender, RoutedEventArgs e)
        {


            var listshowarcher = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                listshowarcher.Add(item.login);

            }
            listarcher.ItemsSource = listshowarcher;

            var listshowrratmir = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                listshowrratmir.Add(item.login);

            }
            listratmits.ItemsSource = listshowrratmir;
            var listshowwarier = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                listshowwarier.Add(item.login);

            }
            listwarier.ItemsSource = listshowwarier;
        }



        private void btXpnac_Click(object sender, RoutedEventArgs e)
        {


            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtxp.Text)
                {
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var str = item._lvlstr;
                    var name = txtxp.Text;
                    var dex = item._lvldex;
                    var lvl = item.Lvl;
                    int Xp = item.Xp + 1000;
                    MongoExtensions.ReplaceUser(txtxp.Text, new War($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtxp.Text)
                {
                    //, item.Lvl, Xp, _int, dex, con, str, pts
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var str = item._lvlstr;
                    var name = txtxp.Text;
                    var dex = item._lvldex;
                    var lvl = item.Lvl;
                    int Xp = item.Xp + 1000;
                    MongoExtensions.ReplaceUserA(txtxp.Text, new Archer($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }

            }



            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtxp.Text)
                {
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var str = item._lvlstr;
                    var name = txtxp.Text;
                    var dex = item._lvldex;
                    var lvl = item.Lvl;
                    int Xp = item.Xp + 1000;
                    MongoExtensions.ReplaceUserR(txtxp.Text, new ratmirs($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }

            }


        }

        private void bt3000_Click(object sender, RoutedEventArgs e)
        {


            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtxp.Text)
                {
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var str = item._lvlstr;
                    var name = txtxp.Text;
                    var dex = item._lvldex;
                    var lvl = item.Lvl;
                    int Xp = item.Xp + 3000;
                    MongoExtensions.ReplaceUser(txtxp.Text,  new War($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtxp.Text)
                {
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var str = item._lvlstr;
                    var name = txtxp.Text;
                    var dex = item._lvldex;
                    var lvl = item.Lvl;
                    int Xp = item.Xp + 3000;
                    MongoExtensions.ReplaceUserA(txtxp.Text, new Archer($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }

            }



            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtxp.Text)
                {
                    var name = txtxp.Text;
                    var lvl = item.Lvl;
                    var str = item._lvlstr;

                    var dex = item._lvldex;
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;

                    int Xp = item.Xp + 3000;
                    MongoExtensions.ReplaceUserR(txtxp.Text, new ratmirs($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }

            }
        }

        private void bt5000_Click(object sender, RoutedEventArgs e)
        {

            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtxp.Text)
                {
                    var name = txtxp.Text;
                    var lvl = item.Lvl;
                    var str = item._lvlstr;

                    var dex = item._lvldex;
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    int Xp = item.Xp + 5000;
                    MongoExtensions.ReplaceUser(name, new War($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtxp.Text)
                {
                    var name = txtxp.Text;
                    var lvl = item.Lvl;
                    var str = item._lvlstr;

                    var dex = item._lvldex;
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    int Xp = item.Xp + 5000;
                    MongoExtensions.ReplaceUserA(name, new Archer($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }

            }



            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtxp.Text)
                {
                    var name = txtxp.Text;
                    var lvl = item.Lvl;
                    var str = item._lvlstr;

                    var dex = item._lvldex;
                    var pts = item._pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    int Xp = item.Xp + 5000;
                    MongoExtensions.ReplaceUserR(name, new ratmirs($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }

            }
        }

        private void Strang_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex;
                    var pts = item.pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var ptss = item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr + 1;
                    MongoExtensions.ReplaceUser(txtUp.Text, new War($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex;
                    var pts = item.pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var ptss = item._pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr + 1;
                    MongoExtensions.ReplaceUserA(txtUp.Text, new Archer($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }

            }
            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtUp.Text)
                {
                    if (item.pts > 0)
                    {
                        var name = txtUp.Text;
                        var lvl = item.Lvl;


                        var dex = item._lvldex;
                        var pts = item.pts;
                        var con = item._lvlcon;
                        var _int = item._lvlint;
                        var ptss = item.pts - 1;
                        int Xp = item.Xp;
                        var str = item._lvlstr + 1;
                        MongoExtensions.ReplaceUserR(txtUp.Text, new ratmirs($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var lststatT = new List<string>();
            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (txtvibor.Text == item.login)
                    lststatT.Add(item.login);
                lststatT.Add((item.str.ToString()));
                lststatT.Add(item.dex.ToString());
                lststatT.Add(item.intel.ToString());
                lststatT.Add(item.con.ToString());
                lststatT.Add(item.Lvl.ToString());

            }
            lststat.ItemsSource = lststatT;


            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (txtvibor.Text == item.login)
                    lststatT.Add(item.login);
                lststatT.Add((item.str.ToString()));
                lststatT.Add(item.dex.ToString());
                lststatT.Add(item.intel.ToString());
                lststatT.Add(item.con.ToString());
                lststatT.Add(item.Lvl.ToString());

            }
            lststat.ItemsSource = lststatT;

            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (txtvibor.Text == item.login)
                    lststatT.Add(item.login);
                lststatT.Add((item.str.ToString()));
                lststatT.Add(item.dex.ToString());
                lststatT.Add(item.intel.ToString());
                lststatT.Add(item.con.ToString());
                lststatT.Add(item.Lvl.ToString());

            }
            lststat.ItemsSource = lststatT;
        }

        private void btlov_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex + 1;
                   
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var pts= item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr;
                    MongoExtensions.ReplaceUser(txtUp.Text, new War($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex + 1;
                    
                    var con = item._lvlcon;
                    var _int = item._lvlint;
                    var ptss = item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr;
                    MongoExtensions.ReplaceUserA(txtUp.Text, new Archer($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }
            }
            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtUp.Text)
                {
                    if (item._pts > 0)
                    {
                        var name = txtUp.Text;
                        var lvl = item.Lvl;


                        var dex = item._lvldex + 1;
                        var pts = item.pts;
                        var con = item._lvlcon;
                        var _int = item._lvlint;
                        var ptss = item.pts - 1;
                        int Xp = item.Xp;
                        var str = item._lvlstr;
                        MongoExtensions.ReplaceUserR(txtUp.Text, new ratmirs($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                    }
                }
            }
        }

        private void btint_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex;
                    var pts = item.pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint+1;
                    var ptss = item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr ;
                    MongoExtensions.ReplaceUser(txtUp.Text, new War($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex;
                    var pts = item.pts;
                    var con = item._lvlcon;
                    var _int = item._lvlint+1;
                    var ptss = item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr ;
                    MongoExtensions.ReplaceUserA(txtUp.Text, new Archer($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }
            }
                foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtUp.Text)
                {
                    if (item._pts > 0)
                    {
                        var name = txtUp.Text;
                        var lvl = item.Lvl;


                        var dex = item._lvldex;
                        var pts = item.pts;
                        var con = item._lvlcon;
                        var _int = item._lvlint + 1;
                        var ptss = item.pts - 1;
                        int Xp = item.Xp;
                        var str = item._lvlstr;
                        MongoExtensions.ReplaceUserR(txtUp.Text, new ratmirs($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                    }
                }
            }
        }

        private void btvin_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MongoExtensions.GetListFromDBWarier())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex;
                    var pts = item.pts;
                    var con = item._lvlcon+1;
                    var _int = item._lvlint ;
                    var ptss = item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr;
                    MongoExtensions.ReplaceUser(txtUp.Text, new War($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }
            }

            foreach (var item in MongoExtensions.GetListFromDBArcher())
            {
                if (item.login == txtUp.Text)
                {
                    var name = txtUp.Text;
                    var lvl = item.Lvl;


                    var dex = item._lvldex;
                    var pts = item.pts;
                    var con = item._lvlcon+1;
                    var _int = item._lvlint ;
                    var ptss = item.pts - 1;
                    int Xp = item.Xp;
                    var str = item._lvlstr;
                    MongoExtensions.ReplaceUserA(txtUp.Text, new Archer($"{ name}", lvl, Xp, ptss, con, dex, _int, str));
                }
            }
            foreach (var item in MongoExtensions.GetListFromDBRatmir())
            {
                if (item.login == txtUp.Text)
                {
                    if (item.pts > 0)
                    {
                        var name = txtUp.Text;
                        var lvl = item.Lvl;


                        var dex = item._lvldex;
                        
                        var con = item._lvlcon+1;
                        var _int = item._lvlint;
                        var pts = item.pts - 1;
                        int Xp = item.Xp;
                        var str = item._lvlstr ;
                        MongoExtensions.ReplaceUserR(txtUp.Text, new ratmirs($"{ name}", lvl, Xp, pts, con, dex, _int, str));
                    }
                }
            }
        }
    }
}
