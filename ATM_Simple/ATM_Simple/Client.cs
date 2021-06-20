using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simple
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Bankcard BankAccount { get; set; }
        public Client(int ıd, string name, string surname, int age, double salary, Bankcard bankAccount)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            this.BankAccount = bankAccount;
        }

        public void ShowClientInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine();
        }
    }
}
