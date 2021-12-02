namespace Labs226_2021
{
    class BankAccount : IBankClient, IBankAdmin
    {
        private string _name;
        private double _balance;

        private static double _rate = 0.007;
        private static double _minWidtraw = 100;
        private static double _maxWidtraw = 5000;
        private static double _minDeposit = 10;
        private static double _comissionForTransaction = 0.02;

        public string Name { get => _name; set => throw new System.NotImplementedException(); }
        public double Balance { get => _balance; set => throw new System.NotImplementedException(); }
        public double Rate { get => _rate; set => _rate = value; }

        public BankAccount(string name, double balance)
        {
            this._name = name;
            this._balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{_name} has {_balance} rubles on balance");
        }

        public void ShowClientBalance(IBankClient bankAccount)
        {
            System.Console.WriteLine($"Client: {bankAccount.Name} has {bankAccount.Balance} ");
        }

    }
}
