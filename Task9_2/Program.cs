namespace Task9_2
{
    internal class Program
    {
        static void Main()
        {
            var acc1 = new BankAccount();

            Console.WriteLine($"Номер счета:{acc1.AccountNumber}");
            Console.WriteLine(acc1.Balance);

            acc1.Deposit();
            Console.WriteLine(acc1.Balance);

            acc1.Withdraw();
            Console.WriteLine(acc1.Balance);

            var acc2 = new BankAccount();

            acc1.AccountCount();

            Console.ReadLine();
        }

        class BankAccount
        {
            Random rnd = new Random();

            // Поля
            private decimal _balance = 0;

            // Статические поля
            private static int TotalAccounts = 0;

            // Свойства
            public readonly int AccountNumber;
            public decimal Balance
            {
                get => _balance;
                private set
                {
                    if (value < 0)
                        throw new ArgumentException("Баланс не может быть отрицательным");
                }
            }

            // Конструктор
            public BankAccount()
            {
                TotalAccounts++;
                AccountNumber = rnd.Next(1110, 9999);
            }

            // Метод– пополняет баланс
            public void Deposit()
            {
                Console.WriteLine("Введите сумму для пополнения баланса");
                decimal instantAmount = Convert.ToDecimal(Console.ReadLine());
                _balance = _balance + instantAmount;
                Balance = _balance;
            }

            // Метод– снимает деньги
            public void Withdraw()
            {
                try
                {
                    Console.WriteLine("Введите сумму для снятия");
                    decimal instantAmount = Convert.ToDecimal(Console.ReadLine());
                    _balance = _balance - instantAmount;
                    if (_balance < 0)
                    {
                        _balance = _balance + instantAmount;
                    }
                    Balance = _balance;

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Недостаточно средств");
                }
            }

            // Метод– показывает текущее количество счетов
            public void AccountCount()
            {
                Console.WriteLine($"Текущее количество счетов {TotalAccounts}");
            }
        }

    }
}
