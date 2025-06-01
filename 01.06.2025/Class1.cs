using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Web
    {
        private string name;
        private string url;
        private string descr;
        private string ip;

        public Web(string name, string url, string descr, string ip) { 
            this.name = name;
            this.url = url; 
            this.descr = descr;
            this.ip = ip;
        }

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Descr
        {
            get { return descr; }
            set { descr = value; }
        }

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public void print() {
            Console.WriteLine($"name: {name} url: {url} descr: {descr} ip: {ip}");
        }
    }

    internal class Journal
    {
        private string name;
        private string data;
        private string descr;
        private string number;
        private string mail;

        public Journal(string name, string data, string descr, string number, string mail)
        {
            this.name = name;
            this.data = data;
            this.descr = descr;
            this.number = number;
            this.mail = mail;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Descr
        {
            get { return descr; }
            set { descr = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public void print()
        {
            Console.WriteLine($"name: {name} data: {data} descr: {descr} number: {number} mail: {mail}");
        }
    }

    internal class Magazin
    {
        private string name;
        private string adress;
        private string descr;
        private string number;
        private string mail;

        public Magazin(string name, string adress, string descr, string number, string mail)
        {
            this.name = name;
            this.adress = adress;
            this.descr = descr;
            this.number = number;
            this.mail = mail;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Descr
        {
            get { return descr; }
            set { descr = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public void print()
        {
            Console.WriteLine($"name: {name} adress: {adress} descr: {descr} number: {number} mail: {mail}");
        }
    }
}
