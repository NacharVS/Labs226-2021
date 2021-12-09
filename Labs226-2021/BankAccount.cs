namespace Labs226_2021
{
    class BankAccount : IBankClient, IBankAdmin
    {
        public delegate void BalanceChangedDelegate(double balance, double oldbalance, double diff);
        public event BalanceChangedDelegate BalanceChangedEvent;

        private string _name;
        private double _balance;

        private static double _rate = 0.007;
        private static double _minWidtraw = 100;
        private static double _maxWidtraw = 5000;
        private static double _minDeposit = 10;
        private static double _comissionForTransaction = 0.02;

        public string Name { get => _name; set => throw new System.NotImplementedException(); }

        public double Balance
        {
            get { return _balance; }
            set 
            {
                double oldBalance = _balance;
                _balance = value;
                double Diff = oldBalance - _balance;
                BalanceChangedEvent?.Invoke(_balance, oldBalance, Diff);
            }
        }

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

        public void ShowClientBalance(BankAccount bankAccount)
        {
            throw new System.NotImplementedException();
        }
    }
}
