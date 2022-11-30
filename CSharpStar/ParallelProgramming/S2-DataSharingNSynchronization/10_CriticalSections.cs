using System;
namespace CSharpStar
{
    public class BankAccount
    {
        private int balance;
        public int Balance
        {
            get { return balance; }
            private set
            {
                balance = value;
            }
        }

        public void Deposit(int amount)
        {
            // +=
            // op1: temp <- get_Balance() + amount
            // op2: set_Balance(temp)
            balance += amount;
            Console.WriteLine($"\nTask with id {Task.CurrentId} processing Deposit");
        }

        public void WithDraw(int amount)
        {
            balance -= amount;
            Console.WriteLine($"\nTask with id {Task.CurrentId} processing WithDraw");
        }

        public void Transfer(BankAccount where, int amount)
        {
            Balance -= amount;
            where.Balance += amount;
        }
    }

    //internal static class CriticalSections
    //{
    //    public static void Main(string[] args)
    //    {
    //        var tasks = new List<Task>();
    //        var ba = new BankAccount();

    //        for (int i = 0; i < 10; i++)
    //        {
    //            tasks.Add(Task.Factory.StartNew(() =>
    //            {
    //                for (int i = 0; i < 100; i++)
    //                {
    //                    ba.Deposit(100);
    //                }
    //            }));
    //        }

    //        for (int i = 0; i < 10; i++)
    //        {
    //            tasks.Add(Task.Factory.StartNew(() =>
    //            {
    //                for (int i = 0; i < 100; i++)
    //                {
    //                    ba.WithDraw(100);
    //                }
    //            }));
    //        }

    //        Task.WaitAll(tasks.ToArray());

    //        Console.WriteLine($"Final balance is {ba.Balance}.");

    //    }
    //}
}

