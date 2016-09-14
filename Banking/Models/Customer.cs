using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    class Customer
    {
        public string Name;
        public int Age;

        public Customer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setName(string name)
        {
            if(name != null)
            {
                this.Name = name;
            }
        }

        public int getAge()
        {
            return this.Age;
        }

        public void setAge(int age)
        {
            if(age != 0)
            {
                this.Age = age;
            }
        }
    }
}
