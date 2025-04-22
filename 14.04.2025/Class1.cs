using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Websait {
        private string name;
        private string url;
        private string descr;
        private string ip;

        public string Name {
            get { return name; }
            set { this.name = value; }
        }

        public string Url { 
            get { return url; }
            set { this.url = value; }
        }

        public string Descr { 
            set { this.descr = value; }
            get { return this.descr; }
        }

        public string Ip { 
            get { return ip; }
            set { this.ip = value; }
        }
        public Websait(string name, string url, string descr, string ip) {
            this.name = name;
            this.url = url;
            this.descr = descr;
            this.ip = ip;
        }

        public void print() {
            Console.WriteLine($"name: {name}, url; {url}, descr: {descr}, ip: {ip}");
        }
    }
}
