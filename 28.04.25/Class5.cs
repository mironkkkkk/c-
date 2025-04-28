using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animal
    {
        private string name;
        private string type;
        private int age;

        public Animal(string name, string type, int age) {
            this.name = name;
            this.type = type;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        public string Type
        {
            get { return type; }
            set { this.name = type; }
        }

        public void print() {
            Console.WriteLine($"name: {name}, age: {age}, type: {type}");
        }

    }
}
