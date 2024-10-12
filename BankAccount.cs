using System;
 
namespace ConsoleApp1.Exam
{
    public class BankAccount
    {
        private decimal _balance;
 
        public decimal Balance
        {
            get { return _balance; }
        }
 
        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentOutOfRangeException("initialBalance", "Initial balance cannot be negative.");
            }
            _balance = initialBalance;
        }
 
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", "Deposit amount must be positive.");
            }
            _balance += amount;
        }
 
        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Withdrawal amount must be positive.";
            }
 
            if (amount > _balance)
            {
                return "Insufficient funds for this withdrawal.";
            }
 
            _balance -= amount;
            return "Withdrawal successful.";
        }
 
        public void Transfer(BankAccount target, decimal amount)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target), "Target account cannot be null.");
            }
 
            if (this.Balance >= amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds for transfer.");
            }
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(1000);
            BankAccount account2 = new BankAccount(500);
 
            account1.Deposit(200);
            Console.WriteLine($"Account 1 Balance: {account1.Balance}");
 
            string withdrawalResult = account1.Withdraw(150);
            Console.WriteLine(withdrawalResult);
            Console.WriteLine($"Account 1 Balance: {account1.Balance}");
 
            try
            {
                account1.Transfer(account2, 300);
                Console.WriteLine("Transfer successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
            Console.WriteLine($"Account 1 Balance: {account1.Balance}");
            Console.WriteLine($"Account 2 Balance: {account2.Balance}");
        }
    }
}

