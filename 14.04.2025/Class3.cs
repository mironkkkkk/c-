using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Shop {
        private string name;
        private string adress;
        private string descr;
        private string number;
        private string mail;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Adress { 
            set { adress = value; } 
            get { return adress; }
        }

        public string Descr
        {
            get { return descr; }
            set { descr = value; }
        }
        public string Number
        {
            set { number = value; }
            get { return number; }
        }

        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        public Shop(string name, string adress, string descr, string number, string mail) { 
            this.name = name;
            this.adress = adress;   
            this.descr = descr;
            this.number = number;
            this.mail = mail;
        }

        public void print() {
            Console.WriteLine($"name: {name}, descr: {descr}, adress: {adress}, number: {number}, mail: {mail}");
        } 
    }
}
