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
            Luchnik._str = 33;
            Luchnik._dex = 199;
            Luchnik._int = 57;
            Luchnik._con = 63;
            Luchnik.ShowInfo();
            Mag._str = 30;
            Mag._dex = 60;
            Mag._int = 214;
            Mag._con = 50;
            Mag.ShowInfo();
            Mag.LvlUp();
            Mag.ShowInfo();
        }
    }
}