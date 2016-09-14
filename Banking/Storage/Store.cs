using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Storage
{
    class Store
    {
        public List<Account> Accounts { get; set; }
        public List<Customer> Customers { get; set; }

        public Store()
        {
            this.Accounts = new List<Account>();
            this.Customers = new List<Customer>();
        }
    }
}
