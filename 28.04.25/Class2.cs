using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Builder : ConsoleApp2.Human
    {
        private int salary;
        private string adress;
        public Builder(string name, string lastname, int age, int salary, string adress) : base(name, lastname, age) {
            this.adress = adress;
            this.salary = salary;
        }

        public int Salary {
            set { this.salary = value; }
            get { return this.salary; }
        }

        public string Adress {
            set { this.adress = value; }
            get { return this.adress; }
        }

        public void printBuilder() {
            print();
            Console.WriteLine($"salary: {salary}, adress: {adress}");
        }
    }
}
