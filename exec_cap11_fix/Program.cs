using exec_cap11_fix.Entities;
using exec_cap11_fix.Entities.Exceptions;
using System;
using System.Globalization;

namespace exec_cap11_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account data:");
                Console.Write("Number:  ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine());
                Account acc = new Account(number, holder, balance, withdraw);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);
                Console.Write("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formation error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
