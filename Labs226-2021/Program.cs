namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Voin = new Warrior();
            Voin.Str = 150;
            Voin.Dex = 30;
            Voin.Int = 25;
            Voin.Con = 60;
            Voin.ShowInfo();
        }
    }
}