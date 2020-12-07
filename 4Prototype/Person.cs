using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Prototype
{
    class Person : ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        private string BankAccount;

        public Person()
        {

        }
        public Person(string name, string surname, string mail, int age)
        {
            Name = name;
            Surname = surname;
            Mail = mail;
            Age = age;
        }

        public string ReturnBankAccount(bool isActive)
        {
            return isActive ? BankAccount : string.Empty;
        }

        public Person Clone()
        {
            return new Person()
            {
                Name = this.Name,
                Surname = this.Surname,
                Age = this.Age,
                Address = this.Address,
                Mail = this.Mail,
                BankAccount = this.BankAccount
            };
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
