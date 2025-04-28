using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Human
    {
        private string name;
        private string lastname;
        private int age;

        public string Name {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Lastname {
            set { this.lastname = value; }
            get { return this.lastname; }
        }

        public int Age {
            set { this.age = value;}
            get { return this.age; }
        }

        public Human(string name, string lastname, int age) {
            this.age = age;
            this.name = name;
            this.lastname = lastname;
        }

        public void print() {
            Console.WriteLine($"name: {name}, lastname: {lastname}, age: {age}");
        }
    }
}
