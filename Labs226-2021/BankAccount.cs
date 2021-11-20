namespace Labs226_2021
{
    class BankAccount
    {
        public string name;
        public double balance;

        public static double rate = 0.007;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double comissionForTransaction = 0.02;



        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {balance}");
        }

        public static void GetProfit(BankAccount acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public void Deposit(double money)
        {

        }

        public void Withdraw(double money)
        {

        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter)
        {

        }
    }
}
