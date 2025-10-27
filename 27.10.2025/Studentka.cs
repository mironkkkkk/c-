using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public class Studentka
    {
        private readonly int id = 0;
        private string name;
        private int age;
        private static int _nextId = 0;

        public int Id => id;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        public Studentka(string name, int age) {
            this.name = name;
            this.age = age;
            this.id = _nextId++;
        }

        public void showStudentka() {
            Console.WriteLine($"name:{name}\nage:{age}\nid:{id}");
        }
    }
}
