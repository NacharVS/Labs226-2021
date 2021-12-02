namespace Labs226_2021
{
    class BankAccount : IBankClient, IBankAdmin
    {
        private string _name;
        private double _balance;
        private int _id;

        private static double _rate = 0.007;
        private static double _minWidtraw = 100;
        private static double _maxWidtraw = 5000;
        private static double _minDeposit = 10;
        private static double _comissionForTransaction = 0.02;

        public string Name { get => _name; set => throw new System.NotImplementedException(); }
        public double Balance { get => _balance; set => _balance = value; }
        public double Rate { get => _rate; set => _rate = value; }
        public int Id { get => _id; set => throw new System.NotImplementedException(); }

        public BankAccount(string name, int id, double balance)
        {
            this._name = name;
            this._id = id;
            this._balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{_name} has {_balance} rubles on balance");
        }

        public void ShowClientBalance(BankAccount bankAccount)
        {
            System.Console.WriteLine($"Client: {bankAccount.Name} has {bankAccount.Balance} ");
        }

        public void Deposid(double money)
        { 
            if (money > _minDeposit)
            {
                Balance += money;
                ShowInfo();
            }
            System.Console.WriteLine("Ограничение по дипозиту");
        }

        public void Withdraw(double money)
        {
            if (money > _minWidtraw & money < _maxWidtraw & money < Balance)
            {
                Balance -= money;
                ShowInfo();
            }
        }

        public void Trade(IBankClient clitntSeller, IBankClient clientGetter, double money)
        {
            if (clitntSeller.Balance > money * _comissionForTransaction + money)
            {
                clitntSeller.Balance -= money * _comissionForTransaction + money;
                clientGetter.Balance += money;
                ShowInfo();
            }
        }

        public void GetProfit(int month)
        {
            Balance += Balance * month;
            ShowInfo();
        }      
        public void BankTrade(IBankClient id,IBankClient  id2, double money)
        {
            if (id.Balance > money * _comissionForTransaction + money)
            {
                id.Balance -= money * _comissionForTransaction + money;
                id2.Balance += money;
                id.ShowInfo();
                id2.ShowInfo();
                
            }
        }
    }
}
