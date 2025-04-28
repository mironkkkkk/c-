using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder FederikoFelini = new Builder("dima", "federiko felini", 14, -100, "bez domni");
            FederikoFelini.printBuilder();
        }
    }
}
