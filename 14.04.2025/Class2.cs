using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Journal {
        private string name;
        private int data;
        private string descr;
        private string number;
        private string mail;

        public Journal(string name, int data, string descr, string number, string mail) {
            this.name = name;
            this.data = data;
            this.descr = descr;
            this.number = number;
            this.mail = mail;
        }

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public string Descr { 
            get { return descr; }
            set { descr = value; }
        }

        public int Data {
            get { return data; }
            set{ data = value; }
        }

        public string Number { 
            set { number = value; }
            get { return number; }  
        }

        public string Mail { 
            set { mail = value; }
            get { return mail; }
        }

        public void print() {
            Console.WriteLine($"name: {name}, descr: {descr}, data: {data}, number: {number}, mail: {mail}");
        }
    }
}
