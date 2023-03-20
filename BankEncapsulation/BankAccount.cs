using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() { }

        private double _balance = 0;

        public BankAccount(double amount)
        {
            _balance = amount;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;

        }
        public double GetBalance()
        {
            return _balance;
        }

        //public void AtBank()
        //{
        //    Console.WriteLine("Hello. Welcome to your bank.\n" +
        //        "What would you like to do?" +
        //        "");
        //} 










    }
}
