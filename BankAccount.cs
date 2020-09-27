using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleApp1
{
    class BankAccount
    {
        public int id;
        public double balance;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;

        }


        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.id = id;
                accounts.Add(id, acc);
            }

        }
        private  void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
             if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                
            }
             else
            {
                Console.WriteLine("Account" + id + ", balance" + balance);
            }
        }
    }
}
