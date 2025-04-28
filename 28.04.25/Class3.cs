using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Passport
    {
        private string name;
        private string lastname;
        private string data;
        private int seria;
        private int number;
        private string gender;
        private string adress;

        public Passport(string name, string lastname, string data, int seria, string gender, string adress, int number) {
            this.name = name;
            this.lastname = lastname;
            this.data = data;
            this.seria = seria;
            this.number = number;
            this.gender = gender;
            this.adress = adress;
        }

        public string Name {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Lastname {
            set { this.lastname = value; }
            get { return this.lastname; }
        }

        public string Data {
            set { this.data = value; }
            get { return this.data; }
        }

        public int Seria {
            set { this.seria = value; }
            get { return this.seria; }
        }

        public int Number {
            set { this.number = value; }
            get { return this.number; }
        }

        public string Gender {
            set { this.gender = value; }
            get { return this.gender; }
        }

        public string Adress {
            set { this.adress = value; }
            get { return this.adress; }
        }

        public void print() {
            Console.WriteLine($"name: {name}, lastname: {lastname}, data: {data}, seria: {seria}, number: {number}, gender: {gender}, adress: {adress}");
        }


    }
}
