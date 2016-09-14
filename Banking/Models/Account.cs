using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    class Account
    {
        public string Number;
        public double Balance;
        public Customer Customer;

        public Account(string number, Customer customer, double balance = 0)
        {
            this.Number = number;
            this.Balance = balance;
            this.Customer = customer;
        }

        public double depositMoney(double amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        public double withdrawMoney(double amount)
        {
            this.Balance -= amount;
            return this.Balance;
        }
    }
}
