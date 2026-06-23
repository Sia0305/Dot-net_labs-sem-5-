using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class BankAccountException : Exception
    {
        public BankAccountException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
    internal class BankAccount
    {
        private int accountNumber;
        private double balance;

        public BankAccount(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new BankAccountException(
                    "Error: Insufficient balance. Available balance = " + balance
                );
            }
            balance -= amount;
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: " + balance);
        }
        public void Display()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
        }
    }
}
