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
        public static double maxDeposit = 10000;
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
            if (money < maxDeposit & money > minDeposit)
            {
                balance += money;
            }
            else
            {
                System.Console.WriteLine("Лимит по депазиту");
            }
        }

        public void Withdraw(double money)
        {
            if (money > minWidtraw)
            {
                if (money < maxWidtraw) 
                { 
                    if (money < balance)
                {
                    balance -= money;
                }
                    else
                    {
                        System.Console.WriteLine("Мало денег на балансе");
                    }

                }
                else
                {
                    System.Console.WriteLine("Мало денег на балансе");
                }
            }
            else
            {
                System.Console.WriteLine("Мало денег на балансе");
            }
        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter , double money)
        {
           if (accSeller.balance > money + (money * comissionForTransaction))
            {
                accSeller.balance -= money + money*comissionForTransaction;
                accGetter.balance += money;
            }
           else
            {
                System.Console.WriteLine("Недостаточно средств");
            }
        }
    }
}
