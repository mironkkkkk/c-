using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ForeignPassport : Passport
    {
        private string visa;
        private string numberForeign;

        public ForeignPassport(string name, string lastname, string data, int seria, string gender, string adress, int number, string visa, string numberForeign) : base(name, lastname, data, seria, gender, adress, number) {
            this.visa = visa;
            this.numberForeign = numberForeign;
        }

        public string Visa {
            get { return visa; }
            set { this.visa = value; }
        }

        public string NumberForeign {
            get { return numberForeign; }
            set { this.numberForeign = value; }
        }

        public void printForeign() {
            print();
            Console.WriteLine($"numberForeign: {numberForeign}, visa: {visa}");
        }
    }
}
