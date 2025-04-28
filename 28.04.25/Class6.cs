using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BombordiroCrocodilo : Animal
    {
        private int countRocket;

        public BombordiroCrocodilo(string name, string type, int age, int num):base(name, type, age) {
            this.countRocket = num;
        }

        public int CountRocket {
            get { return countRocket; }
            set { this.countRocket = value; }
        }

        public void printBombordiroCrocodilo() {
            print();
            Console.WriteLine($"countRocket: {countRocket}");
        }
    }
}
