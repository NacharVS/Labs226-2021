namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client1 = new BankAccount("Обэма", 1, 2000, 1971);
            IClient client2 = new BankAccount("Путин", 2, 900, 1984);
            IAdminAccount admin = new BankAccount("Трамп", 0, 8.79, 2002);
            client1.ShowInfo();
            client1.Transaction(client1, client2, 1000);
            admin.BankTransaction(client1, client2, 500);

        }
    }
}