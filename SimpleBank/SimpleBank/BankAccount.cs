using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        private string name;
        private bool locked = false;
        private double balance;

        public string Name { get { return name; } set { name = value; } }
        public double Balance { get { return balance; } }

        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            this.balance = balance;
            this.locked = locked;
        }

        public BankAccount(string name, double balance) : this(name, balance, false)
        {
        }
        public BankAccount(double balance) : this("", balance, false)
        {
        }

        public void Deposit(double amount)
        {
            if (locked == true)
            {
                Console.WriteLine("Error, Account is locked.");
            }
            else
            {
                balance = Balance + amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (locked)
            {
                Console.WriteLine("Error, Account is locked.");
            }
            else if (Balance < amount)
            {
                Console.WriteLine("You do not have a high enough balance to withdraw this amount.");
            }
            else
            {
                balance = Balance - amount;
            }
        }

        public void ChangeLockState()
        {
            locked = !locked;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Balance: " + Balance;
        }
    }
}
