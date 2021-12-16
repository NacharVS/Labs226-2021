namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Voin = new Warrior();
            Archer Luchnik = new Archer();
            Mage Mag = new Mage();
            Voin._str = 150;
            Voin._dex = 30;
            Voin._int = 25;
            Voin._con = 60;
            Voin.ShowInfo();
            Luchnik._str = 150;
            Luchnik._dex = 30;
            Luchnik._int = 25;
            Luchnik._con = 60;
            Luchnik.ShowInfo();
            Mag._str = 150;
            Mag._dex = 30;
            Mag._int = 25;
            Mag._con = 60;
            Mag.ShowInfo();
            Mag.LvlUp();
            Mag.ShowInfo();
        }
    }
}